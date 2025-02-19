using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LOGINPAGE1 : Form
    {
        public static string s;
        public LOGINPAGE1()
        {
            InitializeComponent();
        }

        private void LOGINPAGE1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox_username.Text == "")
                MessageBox.Show("Make sure that you entered your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                combobox_department.Enabled = true;
        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            if (textBox_username.Text != "")
            {
                s += textBox_username.Text;
                combobox_department.Enabled = true;
                if (combobox_department.Text == "Marketing")
                {

                    MARKETINGDEPARTMENT2 m = new MARKETINGDEPARTMENT2();
                    m.Show();
                    this.Hide();

                }
                else if (combobox_department.Text == "Purchasing Unit")
                {
                    PURCHASINGDEPARTMENT p = new PURCHASINGDEPARTMENT();
                    p.Show();
                    this.Hide();

                }
                else if (combobox_department.Text == "Store Attendant")
                {
                    STOREATTENDANT sa = new STOREATTENDANT();
                    sa.Show();
                    this.Hide();

                }

            }
            else
                MessageBox.Show("Make sure that you entered your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
