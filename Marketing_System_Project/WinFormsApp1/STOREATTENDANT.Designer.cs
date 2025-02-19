
namespace WinFormsApp1
{
    partial class STOREATTENDANT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STOREATTENDANT));
            this.label2 = new System.Windows.Forms.Label();
            this.label_productname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_barcode = new System.Windows.Forms.ComboBox();
            this.textBox_productname = new System.Windows.Forms.TextBox();
            this.textBox_numberofremainingproduct = new System.Windows.Forms.TextBox();
            this.dateTimePicker_expirationdate = new System.Windows.Forms.DateTimePicker();
            this.button_updateexpirationdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_expiredproducts = new System.Windows.Forms.Button();
            this.button_cheapestproduct = new System.Windows.Forms.Button();
            this.button_mostexpensiveproduct = new System.Windows.Forms.Button();
            this.dataGridView_ = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_numberofremainingproducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(151, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "BARCODE:";
            // 
            // label_productname
            // 
            this.label_productname.AutoSize = true;
            this.label_productname.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_productname.ForeColor = System.Drawing.Color.Firebrick;
            this.label_productname.Location = new System.Drawing.Point(61, 224);
            this.label_productname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_productname.Name = "label_productname";
            this.label_productname.Size = new System.Drawing.Size(254, 32);
            this.label_productname.TabIndex = 1;
            this.label_productname.Text = "PRODUCT NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(116, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(527, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMBER OF REMAINING PRODUCTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(24, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "EXPIRATION DATE:";
            // 
            // comboBox_barcode
            // 
            this.comboBox_barcode.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_barcode.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_barcode.FormattingEnabled = true;
            this.comboBox_barcode.Location = new System.Drawing.Point(367, 127);
            this.comboBox_barcode.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_barcode.Name = "comboBox_barcode";
            this.comboBox_barcode.Size = new System.Drawing.Size(414, 40);
            this.comboBox_barcode.TabIndex = 4;
            this.comboBox_barcode.SelectedIndexChanged += new System.EventHandler(this.comboBox_barcode_SelectedIndexChanged);
            // 
            // textBox_productname
            // 
            this.textBox_productname.BackColor = System.Drawing.Color.LightGray;
            this.textBox_productname.Enabled = false;
            this.textBox_productname.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_productname.Location = new System.Drawing.Point(367, 217);
            this.textBox_productname.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_productname.Name = "textBox_productname";
            this.textBox_productname.Size = new System.Drawing.Size(414, 39);
            this.textBox_productname.TabIndex = 5;
            // 
            // textBox_numberofremainingproduct
            // 
            this.textBox_numberofremainingproduct.BackColor = System.Drawing.Color.LightGray;
            this.textBox_numberofremainingproduct.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_numberofremainingproduct.Location = new System.Drawing.Point(194, 371);
            this.textBox_numberofremainingproduct.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_numberofremainingproduct.Name = "textBox_numberofremainingproduct";
            this.textBox_numberofremainingproduct.Size = new System.Drawing.Size(411, 39);
            this.textBox_numberofremainingproduct.TabIndex = 6;
            // 
            // dateTimePicker_expirationdate
            // 
            this.dateTimePicker_expirationdate.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_expirationdate.Location = new System.Drawing.Point(367, 564);
            this.dateTimePicker_expirationdate.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_expirationdate.Name = "dateTimePicker_expirationdate";
            this.dateTimePicker_expirationdate.Size = new System.Drawing.Size(414, 39);
            this.dateTimePicker_expirationdate.TabIndex = 7;
            // 
            // button_updateexpirationdate
            // 
            this.button_updateexpirationdate.BackColor = System.Drawing.Color.LightGray;
            this.button_updateexpirationdate.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_updateexpirationdate.ForeColor = System.Drawing.Color.Firebrick;
            this.button_updateexpirationdate.Location = new System.Drawing.Point(194, 636);
            this.button_updateexpirationdate.Margin = new System.Windows.Forms.Padding(6);
            this.button_updateexpirationdate.Name = "button_updateexpirationdate";
            this.button_updateexpirationdate.Size = new System.Drawing.Size(435, 77);
            this.button_updateexpirationdate.TabIndex = 8;
            this.button_updateexpirationdate.Text = "UPDATE EXPIRATION DATE";
            this.button_updateexpirationdate.UseVisualStyleBackColor = false;
            this.button_updateexpirationdate.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(194, 741);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(435, 77);
            this.button2.TabIndex = 9;
            this.button2.Text = "ADD NEW PRODUCT TO RAYON";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 846);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(670, 290);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_expiredproducts
            // 
            this.button_expiredproducts.BackColor = System.Drawing.Color.LightGray;
            this.button_expiredproducts.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_expiredproducts.ForeColor = System.Drawing.Color.Firebrick;
            this.button_expiredproducts.Location = new System.Drawing.Point(236, 1166);
            this.button_expiredproducts.Margin = new System.Windows.Forms.Padding(6);
            this.button_expiredproducts.Name = "button_expiredproducts";
            this.button_expiredproducts.Size = new System.Drawing.Size(327, 55);
            this.button_expiredproducts.TabIndex = 11;
            this.button_expiredproducts.Text = "EXPIRED PRODUCTS";
            this.button_expiredproducts.UseVisualStyleBackColor = false;
            this.button_expiredproducts.Click += new System.EventHandler(this.button_expiredproducts_Click);
            // 
            // button_cheapestproduct
            // 
            this.button_cheapestproduct.BackColor = System.Drawing.Color.LightGray;
            this.button_cheapestproduct.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cheapestproduct.ForeColor = System.Drawing.Color.Firebrick;
            this.button_cheapestproduct.Location = new System.Drawing.Point(236, 1233);
            this.button_cheapestproduct.Margin = new System.Windows.Forms.Padding(6);
            this.button_cheapestproduct.Name = "button_cheapestproduct";
            this.button_cheapestproduct.Size = new System.Drawing.Size(327, 51);
            this.button_cheapestproduct.TabIndex = 12;
            this.button_cheapestproduct.Text = "CHEAPEST PRODUCT";
            this.button_cheapestproduct.UseVisualStyleBackColor = false;
            this.button_cheapestproduct.Click += new System.EventHandler(this.button_cheapestproduct_Click);
            // 
            // button_mostexpensiveproduct
            // 
            this.button_mostexpensiveproduct.BackColor = System.Drawing.Color.LightGray;
            this.button_mostexpensiveproduct.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_mostexpensiveproduct.ForeColor = System.Drawing.Color.Firebrick;
            this.button_mostexpensiveproduct.Location = new System.Drawing.Point(236, 1296);
            this.button_mostexpensiveproduct.Margin = new System.Windows.Forms.Padding(6);
            this.button_mostexpensiveproduct.Name = "button_mostexpensiveproduct";
            this.button_mostexpensiveproduct.Size = new System.Drawing.Size(327, 51);
            this.button_mostexpensiveproduct.TabIndex = 13;
            this.button_mostexpensiveproduct.Text = "MOST EXPENSIVE PRODUCT";
            this.button_mostexpensiveproduct.UseVisualStyleBackColor = false;
            this.button_mostexpensiveproduct.Click += new System.EventHandler(this.button_mostexpensiveproduct_Click);
            // 
            // dataGridView_
            // 
            this.dataGridView_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_.Location = new System.Drawing.Point(61, 1373);
            this.dataGridView_.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_.Name = "dataGridView_";
            this.dataGridView_.RowHeadersWidth = 82;
            this.dataGridView_.RowTemplate.Height = 25;
            this.dataGridView_.Size = new System.Drawing.Size(704, 296);
            this.dataGridView_.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(306, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // button_numberofremainingproducts
            // 
            this.button_numberofremainingproducts.BackColor = System.Drawing.Color.LightGray;
            this.button_numberofremainingproducts.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_numberofremainingproducts.ForeColor = System.Drawing.Color.Firebrick;
            this.button_numberofremainingproducts.Location = new System.Drawing.Point(116, 441);
            this.button_numberofremainingproducts.Margin = new System.Windows.Forms.Padding(6);
            this.button_numberofremainingproducts.Name = "button_numberofremainingproducts";
            this.button_numberofremainingproducts.Size = new System.Drawing.Size(534, 76);
            this.button_numberofremainingproducts.TabIndex = 16;
            this.button_numberofremainingproducts.Text = "UPDATE NUMBER OF REMAINING PRODUCTS";
            this.button_numberofremainingproducts.UseVisualStyleBackColor = false;
            this.button_numberofremainingproducts.Click += new System.EventHandler(this.button_numberofremainingproducts_Click);
            // 
            // STOREATTENDANT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 1091);
            this.Controls.Add(this.button_numberofremainingproducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_);
            this.Controls.Add(this.button_mostexpensiveproduct);
            this.Controls.Add(this.button_cheapestproduct);
            this.Controls.Add(this.button_expiredproducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_updateexpirationdate);
            this.Controls.Add(this.dateTimePicker_expirationdate);
            this.Controls.Add(this.textBox_numberofremainingproduct);
            this.Controls.Add(this.textBox_productname);
            this.Controls.Add(this.comboBox_barcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_productname);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STOREATTENDANT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE ATTENDANT";
            this.Load += new System.EventHandler(this.STOREATTENDANT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_productname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_barcode;
        private System.Windows.Forms.TextBox textBox_productname;
        private System.Windows.Forms.TextBox textBox_numberofremainingproduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expirationdate;
        private System.Windows.Forms.Button button_updateexpirationdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_expiredproducts;
        private System.Windows.Forms.Button button_cheapestproduct;
        private System.Windows.Forms.Button button_mostexpensiveproduct;
        private System.Windows.Forms.DataGridView dataGridView_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_numberofremainingproducts;
    }
}