
namespace WinFormsApp1
{
    partial class MARKETINGDEPARTMENT2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MARKETINGDEPARTMENT2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_addnewcustomer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_totalprice = new System.Windows.Forms.TextBox();
            this.textBox_unitprice = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_productname = new System.Windows.Forms.TextBox();
            this.textBox_customername = new System.Windows.Forms.TextBox();
            this.comboBox_productid = new System.Windows.Forms.ComboBox();
            this.comboBox_customerid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_unitprice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_statistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 959);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(631, 288);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_addnewcustomer
            // 
            this.button_addnewcustomer.BackColor = System.Drawing.Color.LightGray;
            this.button_addnewcustomer.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addnewcustomer.ForeColor = System.Drawing.Color.Firebrick;
            this.button_addnewcustomer.Location = new System.Drawing.Point(202, 789);
            this.button_addnewcustomer.Margin = new System.Windows.Forms.Padding(6);
            this.button_addnewcustomer.Name = "button_addnewcustomer";
            this.button_addnewcustomer.Size = new System.Drawing.Size(422, 58);
            this.button_addnewcustomer.TabIndex = 36;
            this.button_addnewcustomer.Text = "ADD NEW CUSTOMER";
            this.button_addnewcustomer.UseVisualStyleBackColor = false;
            this.button_addnewcustomer.Click += new System.EventHandler(this.button_addnewcustomer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(449, 699);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 60);
            this.button2.TabIndex = 35;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.LightGray;
            this.button_update.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.Firebrick;
            this.button_update.Location = new System.Drawing.Point(202, 699);
            this.button_update.Margin = new System.Windows.Forms.Padding(6);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(161, 60);
            this.button_update.TabIndex = 34;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_totalprice
            // 
            this.textBox_totalprice.BackColor = System.Drawing.Color.LightGray;
            this.textBox_totalprice.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_totalprice.Location = new System.Drawing.Point(295, 590);
            this.textBox_totalprice.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_totalprice.Name = "textBox_totalprice";
            this.textBox_totalprice.Size = new System.Drawing.Size(409, 39);
            this.textBox_totalprice.TabIndex = 33;
            // 
            // textBox_unitprice
            // 
            this.textBox_unitprice.BackColor = System.Drawing.Color.LightGray;
            this.textBox_unitprice.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_unitprice.Location = new System.Drawing.Point(295, 514);
            this.textBox_unitprice.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_unitprice.Name = "textBox_unitprice";
            this.textBox_unitprice.Size = new System.Drawing.Size(409, 39);
            this.textBox_unitprice.TabIndex = 32;
            // 
            // textBox_amount
            // 
            this.textBox_amount.BackColor = System.Drawing.Color.LightGray;
            this.textBox_amount.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_amount.Location = new System.Drawing.Point(295, 439);
            this.textBox_amount.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(409, 39);
            this.textBox_amount.TabIndex = 31;
            // 
            // textBox_productname
            // 
            this.textBox_productname.BackColor = System.Drawing.Color.LightGray;
            this.textBox_productname.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_productname.Location = new System.Drawing.Point(295, 363);
            this.textBox_productname.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_productname.Name = "textBox_productname";
            this.textBox_productname.Size = new System.Drawing.Size(409, 39);
            this.textBox_productname.TabIndex = 30;
            // 
            // textBox_customername
            // 
            this.textBox_customername.BackColor = System.Drawing.Color.LightGray;
            this.textBox_customername.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_customername.Location = new System.Drawing.Point(295, 216);
            this.textBox_customername.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_customername.Name = "textBox_customername";
            this.textBox_customername.Size = new System.Drawing.Size(409, 39);
            this.textBox_customername.TabIndex = 29;
            this.textBox_customername.TextChanged += new System.EventHandler(this.textBox_customername_TextChanged);
            // 
            // comboBox_productid
            // 
            this.comboBox_productid.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_productid.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_productid.FormattingEnabled = true;
            this.comboBox_productid.Location = new System.Drawing.Point(295, 288);
            this.comboBox_productid.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_productid.Name = "comboBox_productid";
            this.comboBox_productid.Size = new System.Drawing.Size(409, 40);
            this.comboBox_productid.TabIndex = 28;
            this.comboBox_productid.SelectedIndexChanged += new System.EventHandler(this.comboBox_productid_SelectedIndexChanged);
            // 
            // comboBox_customerid
            // 
            this.comboBox_customerid.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_customerid.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_customerid.FormattingEnabled = true;
            this.comboBox_customerid.Location = new System.Drawing.Point(295, 137);
            this.comboBox_customerid.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_customerid.Name = "comboBox_customerid";
            this.comboBox_customerid.Size = new System.Drawing.Size(409, 40);
            this.comboBox_customerid.TabIndex = 27;
            this.comboBox_customerid.SelectedIndexChanged += new System.EventHandler(this.comboBox_customerid_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(73, 597);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "TOTAL PRICE:";
            // 
            // label_unitprice
            // 
            this.label_unitprice.AutoSize = true;
            this.label_unitprice.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_unitprice.ForeColor = System.Drawing.Color.Firebrick;
            this.label_unitprice.Location = new System.Drawing.Point(99, 521);
            this.label_unitprice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_unitprice.Name = "label_unitprice";
            this.label_unitprice.Size = new System.Drawing.Size(191, 32);
            this.label_unitprice.TabIndex = 25;
            this.label_unitprice.Text = "UNIT PRICE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(144, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "AMOUNT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(36, 370);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "PRODUCT NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(88, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "PRODUCT ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(18, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "CUSTOMER NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(64, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "CUSTOMER ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(295, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "label1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_statistics
            // 
            this.button_statistics.BackColor = System.Drawing.Color.LightGray;
            this.button_statistics.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_statistics.ForeColor = System.Drawing.Color.Firebrick;
            this.button_statistics.Location = new System.Drawing.Point(202, 869);
            this.button_statistics.Margin = new System.Windows.Forms.Padding(6);
            this.button_statistics.Name = "button_statistics";
            this.button_statistics.Size = new System.Drawing.Size(422, 54);
            this.button_statistics.TabIndex = 41;
            this.button_statistics.Text = "CLICK TO SEE STATISTICS";
            this.button_statistics.UseVisualStyleBackColor = false;
            this.button_statistics.Click += new System.EventHandler(this.button_statistics_Click);
            // 
            // MARKETINGDEPARTMENT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 1149);
            this.Controls.Add(this.button_statistics);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_addnewcustomer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_totalprice);
            this.Controls.Add(this.textBox_unitprice);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_productname);
            this.Controls.Add(this.textBox_customername);
            this.Controls.Add(this.comboBox_productid);
            this.Controls.Add(this.comboBox_customerid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_unitprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MARKETINGDEPARTMENT2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKETING DEPARTMENT";
            this.Load += new System.EventHandler(this.MARKETINGDEPARTMENT2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_addnewcustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_totalprice;
        private System.Windows.Forms.TextBox textBox_unitprice;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_productname;
        private System.Windows.Forms.TextBox textBox_customername;
        private System.Windows.Forms.ComboBox comboBox_productid;
        private System.Windows.Forms.ComboBox comboBox_customerid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_unitprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_statistics;
    }
}