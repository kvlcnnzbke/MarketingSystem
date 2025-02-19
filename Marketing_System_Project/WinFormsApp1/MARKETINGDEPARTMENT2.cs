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
    public partial class MARKETINGDEPARTMENT2 : Form
    {
        public MARKETINGDEPARTMENT2()
        {
            InitializeComponent();
        }

        private void FilltheDataGridView()
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select tblCUSTOMER.customerid, tblCUSTOMER.customername, tblCUSTOMER.amount, tblCUSTOMER.totalprice, tblPRODUCT.productid, tblPRODUCT.productname, tblPRODUCT.unitprice from tblCUSTOMER, tblPRODUCT where tblCUSTOMER.productid=tblPRODUCT.productid; ";
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
        private void textBox_unitprice_TextChanged1(object sender, EventArgs e)
        {
            if (textBox_totalprice.Text != " ")
            {
                string c, query;
                c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
                SqlConnection con = new SqlConnection(c);
                query = "update tblCUSTOMER set totalprice =" + textBox_totalprice.Text + " where customerid = " + comboBox_customerid.Text + ";";


                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();


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
                textBox_totalprice.Text = (Convert.ToInt16(textBox_amount.Text) * Convert.ToInt16(textBox_unitprice.Text)).ToString();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            comboBox_customerid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_customername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox_productid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_productname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_amount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_unitprice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_totalprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void MARKETINGDEPARTMENT2_Load_1(object sender, EventArgs e)
        {
           
            label5.Text = "WELCOME " + LOGINPAGE1.s;
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select customerid from tblCUSTOMER ;";
            SqlCommand comm = new SqlCommand(query, con);

            con.Open();
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                comboBox_customerid.Items.Add(r["customerid"]);
            }

            con.Close();
            
            FilltheDataGridView();
            clearthepage();
        }

        private void comboBox_customerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_productid.Items.Clear();
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select customername from tblCUSTOMER where customerid= " + comboBox_customerid.Text;
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                textBox_customername.Enabled = true;
                comboBox_productid.Enabled = true;
                textBox_customername.Text = dr["customername"].ToString();

            }

            con.Close();
        }

        private void comboBox_productid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select productname,unitprice from tblPRODUCT where productid= " + comboBox_productid.Text;
            SqlCommand comm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                textBox_productname.Enabled = true;
                textBox_unitprice.Enabled = true;

                textBox_productname.Text = dr["productname"].ToString();
                textBox_unitprice.Text = dr["unitprice"].ToString();


            }

            

            con.Close();

        }

        private void textBox_customername_TextChanged(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select productid from tblCUSTOMER ;";
            SqlCommand comm = new SqlCommand(query, con);

            con.Open();
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                comboBox_productid.Items.Add(r["productid"]);
            }

            con.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_customername.Text != " ")
            {
                string c, query;
                c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
                SqlConnection con = new SqlConnection(c);
                textBox_totalprice.Text = (Convert.ToInt16(textBox_amount.Text) * Convert.ToInt16(textBox_unitprice.Text)).ToString();
                query = "update tblCUSTOMER set amount =" + textBox_amount.Text + " , totalprice = " + textBox_totalprice.Text + "where customerid = " + comboBox_customerid.Text + ";";


                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("The data for the customer " + textBox_customername.Text + " has been updated");

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
            textBox_totalprice.Text = (Convert.ToInt16(textBox_amount.Text) * Convert.ToInt16(textBox_unitprice.Text)).ToString();
        }

        private void button_statistics_Click(object sender, EventArgs e)
        {
            marketingstatistics m = new marketingstatistics();
            m.Show();
            this.Hide();
        }

        public void clearthepage()
        {
            comboBox_customerid.Text = "";
            textBox_customername.Text = "";
            comboBox_productid.Text = "";
            textBox_productname.Text = "";
            textBox_amount.Text = "";
            textBox_unitprice.Text = "";
            textBox_totalprice.Text = "";
            
        }

        private void button_addnewcustomer_Click(object sender, EventArgs e)
        {
            addnewcustomerformarketing ad = new addnewcustomerformarketing();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_customerid.Text != "")
            {
               
                string c, query;
                c = "server=.\\SQLEXPRESS; database=Student; integrated security=true";
                SqlConnection con = new SqlConnection(c);
                query = "delete from tblCUSTOMER where customerid=" + comboBox_customerid.Text;
                SqlCommand comm = new SqlCommand(query, con);
                try
                {

                    comm.ExecuteNonQuery();
                    MessageBox.Show("The data for the customer " + comboBox_customerid.Text + " has been deleted");
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

                clearthepage();
            }
            else
                MessageBox.Show("You have to choose a student");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /* private void textBox_amount_TextChanged1(object sender, EventArgs e)
         {
             textBox_totalprice.Text = (Convert.ToInt16(textBox_amount.Text) * Convert.ToInt16(textBox_unitprice.Text)).ToString();
             if (textBox_totalprice.Text != " ")
             {
                 string c, query;
                 c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
                 SqlConnection con = new SqlConnection(c);
                 query = "update tblCUSTOMER set totalprice =" + textBox_totalprice.Text + " where customerid = " + comboBox_customerid.Text + ";";


                 SqlCommand com = new SqlCommand(query, con);
                 try
                 {
                     con.Open();
                     com.ExecuteNonQuery();


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
         }*/
    }
}
