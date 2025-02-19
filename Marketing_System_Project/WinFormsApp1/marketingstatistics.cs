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
    public partial class marketingstatistics : Form
    {
        public marketingstatistics()
        {
            InitializeComponent();
        }

        private void button_turnback1_Click(object sender, EventArgs e)
        {
            MARKETINGDEPARTMENT2 md = new MARKETINGDEPARTMENT2();
            md.Show();
            this.Hide();
        }

        private void comboBox_productid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select tblCUSTOMER.customerid,tblPRODUCT.productid from tblCUSTOMER,tblPRODUCT where tblPRODUCT.productid=tblCUSTOMER.productid and tblPRODUCT.productid= "+ comboBox_productid.Text +";" ;        
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
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

        private void comboBox_idcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select tblCUSTOMER.customerid,tblPRODUCT.productid from tblCUSTOMER,tblPRODUCT where tblPRODUCT.productid=tblCUSTOMER.productid and tblCUSTOMER.customerid= "+ comboBox_idcustomer.Text +";" ;        
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
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

        private void button_click1_Click(object sender, EventArgs e)
        {
            comboBox_productid.Items.Clear();
            comboBox_productid.Enabled = true;
            
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select productid from tblPRODUCT ;";
            SqlCommand comm = new SqlCommand(query, con);

            con.Open();
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                comboBox_productid.Items.Add(r["productid"]);
            }

            con.Close();
        }

        private void button_click2_Click(object sender, EventArgs e)
        {
            comboBox_idcustomer.Items.Clear();
            comboBox_productid.Enabled = false;
            comboBox_idcustomer.Enabled = true;
            
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select customerid from tblCUSTOMER ;";
            SqlCommand comm = new SqlCommand(query, con);

            con.Open();
            SqlDataReader r = comm.ExecuteReader();
            while (r.Read())
            {
                comboBox_idcustomer.Items.Add(r["customerid"]);
            }

            con.Close();
        }

        private void marketingstatistics_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox_totalnumberofcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select count(customerid) from tblCUSTOMER;";
            con.Open();
            SqlCommand comm = new SqlCommand(query, con);
            label3.Text = comm.ExecuteScalar().ToString();
            con.Close();

        }

        private void button_totalpurchasedamount_Click(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select sum(totalprice) from tblCUSTOMER;";
            con.Open();
            SqlCommand comm = new SqlCommand(query, con);
            label_totalpuchasedamount2.Text = comm.ExecuteScalar().ToString();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select top 1 productid from tblCUSTOMER order by amount desc;";
            con.Open();
            SqlCommand comm = new SqlCommand(query, con);
            label4.Text = comm.ExecuteScalar().ToString();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string c, query;
            c = "server=.\\SQLEXPRESS; database=project218; integrated security=true";
            SqlConnection con = new SqlConnection(c);
            query = "select top 1 customerid from tblCUSTOMER order by amount desc;";
            con.Open();
            SqlCommand comm = new SqlCommand(query, con);
            label5.Text = comm.ExecuteScalar().ToString();
            con.Close();
        }
    }
}

