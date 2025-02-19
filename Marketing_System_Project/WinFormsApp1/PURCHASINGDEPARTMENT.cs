using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class PURCHASINGDEPARTMENT : Form
    {
        public PURCHASINGDEPARTMENT()
        {
            InitializeComponent();
        }

       

        private void PURCHASINGDEPARTMENT_Load(object sender, EventArgs e)
        {
            label5.Text = "WELCOME " + LOGINPAGE1.s;
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select supplierid from tblSUPPLIER ;";
            SqlCommand comm = new SqlCommand(query, con);

            con.Open();
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                comboBox_supplerid.Items.Add(r["supplierid"]);
            }

            con.Close();

            FilltheDataGridView();
        }
        private void FilltheDataGridView()
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
           
            query = "select tblSUPPLIER.supplierid, tblSUPPLIER.suppliername, tblPROSUP.dateoforder, tblPROSUP.amountoforder from tblSUPPLIER, tblPROSUP where tblSUPPLIER.supplierid=tblPROSUP.supplierid; ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            try
            {

                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception a)
            {
                MessageBox.Show("A connection problem or query problem has been occured");
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox_supplerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select suppliername from tblSUPPLIER where supplierid= " + comboBox_supplerid.Text;
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                textBox_suppliername.Enabled = true;
                
                textBox_suppliername.Text = dr["suppliername"].ToString();

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            comboBox_supplerid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_suppliername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_amountoforder.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();    
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (comboBox_supplerid.Text != " ")
            {
                string c, query;
                c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
                SqlConnection con = new SqlConnection(c);
                query = "update tblPROSUP set amountoforder = '" + textBox_amountoforder.Text + " ' where supplierid = " + comboBox_supplerid.Text + ";";

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("The data for the supplier ID " + comboBox_supplerid.Text + " has been updated");

                }
                catch (Exception a)
                {
                    MessageBox.Show("A connection problem or query problem has been occured");
                }
                finally
                {
                    con.Close();
                }
                FilltheDataGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_supplerid.Text != " ")
            {
                string c, query;
                c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
                SqlConnection con = new SqlConnection(c);
                query = "update tblPROSUP set dateoforder = '" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + " ' where supplierid = " + comboBox_supplerid.Text + ";";

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("The data for the supplier ID " + comboBox_supplerid.Text + " has been updated");

                }
                catch (Exception a)
                {
                    MessageBox.Show("A connection problem or query problem has been occured");
                }
                finally
                {
                    con.Close();
                }
                FilltheDataGridView();
            }
        }
    }
}
