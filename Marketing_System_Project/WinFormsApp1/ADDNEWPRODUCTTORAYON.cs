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
    public partial class ADDNEWPRODUCTTORAYON : Form
    {
        public ADDNEWPRODUCTTORAYON()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_newproductbarcode.Text != "")
            {
                textBox_newproductname.Enabled = true;

                dateTimePicker_newproductexpirationdate.Enabled = true;
                string c, query;
                c = "server= .\\SQLEXPRESS; database=project218; integrated security=true";
                SqlConnection con = new SqlConnection(c);

                query = "insert into tblPRODUCT(productid,productname,unitprice) values (" + textBox_newproductbarcode.Text + ",'" + textBox_newproductname.Text + "'," + textBox_unitpricenew.Text + ");";
                query += "insert into tblPROSUP (productid,expirationdate) values ( " + textBox_newproductbarcode.Text + ","+dateTimePicker_newproductexpirationdate.Value.ToString("yyyy.MM.dd")+");";

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



        }   }

        private void textBox_newproductbarcode_TextChanged(object sender, EventArgs e)
        {
            textBox_newproductname.Enabled = true;

            dateTimePicker_newproductexpirationdate.Enabled = true;
        }

        private void ADDNEWPRODUCTTORAYON_Load(object sender, EventArgs e)
        {

        }

        private void button_turnback_Click(object sender, EventArgs e)
        {
            STOREATTENDANT std = new STOREATTENDANT();
            std.Show();
            this.Close();
        }
    }
}
