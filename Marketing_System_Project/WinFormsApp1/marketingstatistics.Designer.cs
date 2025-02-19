
namespace WinFormsApp1
{
    partial class marketingstatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marketingstatistics));
            this.button_turnback1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_productid = new System.Windows.Forms.ComboBox();
            this.label_boughtproducts = new System.Windows.Forms.Label();
            this.comboBox_idcustomer = new System.Windows.Forms.ComboBox();
            this.button_click1 = new System.Windows.Forms.Button();
            this.button_click2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_totalpuchasedamount2 = new System.Windows.Forms.Label();
            this.button_totalpurchasedamount = new System.Windows.Forms.Button();
            this.label_totalpurchasedamount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_turnback1
            // 
            this.button_turnback1.BackColor = System.Drawing.Color.LightGray;
            this.button_turnback1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_turnback1.ForeColor = System.Drawing.Color.Firebrick;
            this.button_turnback1.Location = new System.Drawing.Point(33, 1202);
            this.button_turnback1.Margin = new System.Windows.Forms.Padding(6);
            this.button_turnback1.Name = "button_turnback1";
            this.button_turnback1.Size = new System.Drawing.Size(287, 58);
            this.button_turnback1.TabIndex = 0;
            this.button_turnback1.Text = "◄ TURN BACK ";
            this.button_turnback1.UseVisualStyleBackColor = false;
            this.button_turnback1.Click += new System.EventHandler(this.button_turnback1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 806);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(633, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click to button to choose a product id to list customers who bought it";
            // 
            // comboBox_productid
            // 
            this.comboBox_productid.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_productid.Enabled = false;
            this.comboBox_productid.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_productid.ForeColor = System.Drawing.Color.Black;
            this.comboBox_productid.FormattingEnabled = true;
            this.comboBox_productid.Location = new System.Drawing.Point(33, 154);
            this.comboBox_productid.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_productid.Name = "comboBox_productid";
            this.comboBox_productid.Size = new System.Drawing.Size(520, 40);
            this.comboBox_productid.TabIndex = 3;
            this.comboBox_productid.SelectedIndexChanged += new System.EventHandler(this.comboBox_productid_SelectedIndexChanged);
            // 
            // label_boughtproducts
            // 
            this.label_boughtproducts.AutoSize = true;
            this.label_boughtproducts.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_boughtproducts.ForeColor = System.Drawing.Color.Firebrick;
            this.label_boughtproducts.Location = new System.Drawing.Point(22, 252);
            this.label_boughtproducts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_boughtproducts.Name = "label_boughtproducts";
            this.label_boughtproducts.Size = new System.Drawing.Size(883, 28);
            this.label_boughtproducts.TabIndex = 4;
            this.label_boughtproducts.Text = "Click to button to choose a customer id to see all products purchased";
            // 
            // comboBox_idcustomer
            // 
            this.comboBox_idcustomer.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_idcustomer.Enabled = false;
            this.comboBox_idcustomer.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_idcustomer.ForeColor = System.Drawing.Color.Black;
            this.comboBox_idcustomer.FormattingEnabled = true;
            this.comboBox_idcustomer.Location = new System.Drawing.Point(22, 320);
            this.comboBox_idcustomer.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_idcustomer.Name = "comboBox_idcustomer";
            this.comboBox_idcustomer.Size = new System.Drawing.Size(520, 40);
            this.comboBox_idcustomer.TabIndex = 5;
            this.comboBox_idcustomer.SelectedIndexChanged += new System.EventHandler(this.comboBox_idcustomer_SelectedIndexChanged);
            // 
            // button_click1
            // 
            this.button_click1.BackColor = System.Drawing.Color.LightGray;
            this.button_click1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_click1.ForeColor = System.Drawing.Color.Firebrick;
            this.button_click1.Location = new System.Drawing.Point(574, 141);
            this.button_click1.Margin = new System.Windows.Forms.Padding(6);
            this.button_click1.Name = "button_click1";
            this.button_click1.Size = new System.Drawing.Size(169, 70);
            this.button_click1.TabIndex = 6;
            this.button_click1.Text = "CLICK";
            this.button_click1.UseVisualStyleBackColor = false;
            this.button_click1.Click += new System.EventHandler(this.button_click1_Click);
            // 
            // button_click2
            // 
            this.button_click2.BackColor = System.Drawing.Color.LightGray;
            this.button_click2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_click2.ForeColor = System.Drawing.Color.Firebrick;
            this.button_click2.Location = new System.Drawing.Point(574, 307);
            this.button_click2.Margin = new System.Windows.Forms.Padding(6);
            this.button_click2.Name = "button_click2";
            this.button_click2.Size = new System.Drawing.Size(169, 68);
            this.button_click2.TabIndex = 7;
            this.button_click2.Text = "CLICK";
            this.button_click2.UseVisualStyleBackColor = false;
            this.button_click2.Click += new System.EventHandler(this.button_click2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(33, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(647, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 9;
            // 
            // label_totalpuchasedamount2
            // 
            this.label_totalpuchasedamount2.AutoSize = true;
            this.label_totalpuchasedamount2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_totalpuchasedamount2.ForeColor = System.Drawing.Color.Firebrick;
            this.label_totalpuchasedamount2.Location = new System.Drawing.Point(647, 525);
            this.label_totalpuchasedamount2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_totalpuchasedamount2.Name = "label_totalpuchasedamount2";
            this.label_totalpuchasedamount2.Size = new System.Drawing.Size(0, 32);
            this.label_totalpuchasedamount2.TabIndex = 11;
            // 
            // button_totalpurchasedamount
            // 
            this.button_totalpurchasedamount.BackColor = System.Drawing.Color.LightGray;
            this.button_totalpurchasedamount.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_totalpurchasedamount.ForeColor = System.Drawing.Color.Firebrick;
            this.button_totalpurchasedamount.Location = new System.Drawing.Point(15, 525);
            this.button_totalpurchasedamount.Margin = new System.Windows.Forms.Padding(6);
            this.button_totalpurchasedamount.Name = "button_totalpurchasedamount";
            this.button_totalpurchasedamount.Size = new System.Drawing.Size(538, 48);
            this.button_totalpurchasedamount.TabIndex = 12;
            this.button_totalpurchasedamount.Text = "TOTAL PURCHASED AMOUNT";
            this.button_totalpurchasedamount.UseVisualStyleBackColor = false;
            this.button_totalpurchasedamount.Click += new System.EventHandler(this.button_totalpurchasedamount_Click);
            // 
            // label_totalpurchasedamount
            // 
            this.label_totalpurchasedamount.AutoSize = true;
            this.label_totalpurchasedamount.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_totalpurchasedamount.Location = new System.Drawing.Point(22, 599);
            this.label_totalpurchasedamount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_totalpurchasedamount.Name = "label_totalpurchasedamount";
            this.label_totalpurchasedamount.Size = new System.Drawing.Size(0, 32);
            this.label_totalpurchasedamount.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(15, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(538, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "TOTAL NUMBER OF CUSTOMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(15, 589);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(538, 51);
            this.button2.TabIndex = 14;
            this.button2.Text = "ID OF THE BEST SELLER PRODUCT ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(647, 589);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(15, 657);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(538, 61);
            this.button3.TabIndex = 16;
            this.button3.Text = "THE ID OF CUSTOMER WHO BUYS MOST";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(647, 657);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 17;
            // 
            // marketingstatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 1049);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_totalpurchasedamount);
            this.Controls.Add(this.label_totalpuchasedamount2);
            this.Controls.Add(this.label_totalpurchasedamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_click2);
            this.Controls.Add(this.button_click1);
            this.Controls.Add(this.comboBox_idcustomer);
            this.Controls.Add(this.label_boughtproducts);
            this.Controls.Add(this.comboBox_productid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_turnback1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "marketingstatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKETING STATISTICS";
            this.Load += new System.EventHandler(this.marketingstatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_turnback1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_productid;
        private System.Windows.Forms.Label label_boughtproducts;
        private System.Windows.Forms.ComboBox comboBox_idcustomer;
        private System.Windows.Forms.Button button_click1;
        private System.Windows.Forms.Button button_click2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_totalpuchasedamount2;
        private System.Windows.Forms.Button button_totalpurchasedamount;
        private System.Windows.Forms.Label label_totalpurchasedamount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}