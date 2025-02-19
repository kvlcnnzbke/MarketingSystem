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
    public partial class STOREATTENDANT : Form
    {
        public STOREATTENDANT()
        {
            InitializeComponent();
        }

        private void STOREATTENDANT_Load(object sender, EventArgs e)
        {
            FilltheDataGridView();
            label1.Text = "WELCOME " + LOGINPAGE1.s;
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select productid from tblPRODUCT ;";
            SqlCommand comm = new SqlCommand(query, con);

            con.Open();
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                comboBox_barcode.Items.Add(r["productid"]);
            }

            con.Close();
            clearthepage();
           
        }

        private void comboBox_barcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select tblPRODUCT.productname,tblPROSUP.expirationdate from tblPRODUCT , tblPROSUP where tblPRODUCT.productid= " + comboBox_barcode.Text+"and tblPRODUCT.productid=tblPROSUP.productid;";
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                textBox_productname.Enabled = true;
                textBox_productname.Text = dr["productname"].ToString();
                dateTimePicker_expirationdate.Value = DateTime.Today;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDNEWPRODUCTTORAYON f = new ADDNEWPRODUCTTORAYON();
            f.Show();
            this.Hide();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_numberofremainingproduct.Text != " ")
            {
                string c, query;
                c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
                SqlConnection con = new SqlConnection(c);
                query = "update tblPROSUP set expirationdate = '" + dateTimePicker_expirationdate.Value.ToString("yyyy.MM.dd") + " ' where productid = " + comboBox_barcode.Text + ";";

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("The data for the product ID " + comboBox_barcode.Text + " has been updated");

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
        private void FilltheDataGridView()
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select supplierid, productid, remaining,expirationdate from tblPROSUP ; ";
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            comboBox_barcode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_numberofremainingproduct.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_expirationdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_expiredproducts_Click(object sender, EventArgs e)
        {
            comboBox_barcode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_numberofremainingproduct.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_expirationdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);

            query = "select productid from tblPROSUP where convert(date, expirationdate,103) < convert (date,getdate(),103);";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            try
            {
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView_.DataSource = dt;
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

        private void button_cheapestproduct_Click(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);

            query = "select top 1  productid,unitprice  from tblPRODUCT order by unitprice asc;  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            try
            {
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView_.DataSource = dt;


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

        private void button_mostexpensiveproduct_Click(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);

            query = "select top 1 productid,unitprice from tblPRODUCT order by unitprice desc;  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            try
            {
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView_.DataSource = dt;


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

        private void button_numberofremainingproducts_Click(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "update tblPROSUP set remaining =" + textBox_numberofremainingproduct.Text + " where productid = " + comboBox_barcode.Text + ";";

            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("The data for the product ID " + comboBox_barcode.Text + " has been updated");

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
        public void clearthepage()
        {
            comboBox_barcode.Text = "";
            textBox_productname.Text = "";
            textBox_numberofremainingproduct.Text = "";
            dateTimePicker_expirationdate.Value = DateTime.Today;
        }

       
    }
}

