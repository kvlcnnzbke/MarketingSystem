
namespace WinFormsApp1
{
    partial class ADDNEWPRODUCTTORAYON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDNEWPRODUCTTORAYON));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_newproductbarcode = new System.Windows.Forms.TextBox();
            this.textBox_newproductname = new System.Windows.Forms.TextBox();
            this.dateTimePicker_newproductexpirationdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label_unitpricenew = new System.Windows.Forms.Label();
            this.textBox_unitpricenew = new System.Windows.Forms.TextBox();
            this.button_turnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(136, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARCODE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(46, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(9, 508);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "EXPIRATION DATE:";
            // 
            // textBox_newproductbarcode
            // 
            this.textBox_newproductbarcode.BackColor = System.Drawing.Color.LightGray;
            this.textBox_newproductbarcode.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_newproductbarcode.Location = new System.Drawing.Point(310, 231);
            this.textBox_newproductbarcode.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_newproductbarcode.Name = "textBox_newproductbarcode";
            this.textBox_newproductbarcode.Size = new System.Drawing.Size(463, 39);
            this.textBox_newproductbarcode.TabIndex = 3;
            this.textBox_newproductbarcode.TextChanged += new System.EventHandler(this.textBox_newproductbarcode_TextChanged);
            // 
            // textBox_newproductname
            // 
            this.textBox_newproductname.BackColor = System.Drawing.Color.LightGray;
            this.textBox_newproductname.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_newproductname.Location = new System.Drawing.Point(310, 319);
            this.textBox_newproductname.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_newproductname.Name = "textBox_newproductname";
            this.textBox_newproductname.Size = new System.Drawing.Size(463, 39);
            this.textBox_newproductname.TabIndex = 4;
            // 
            // dateTimePicker_newproductexpirationdate
            // 
            this.dateTimePicker_newproductexpirationdate.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_newproductexpirationdate.Location = new System.Drawing.Point(312, 501);
            this.dateTimePicker_newproductexpirationdate.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_newproductexpirationdate.Name = "dateTimePicker_newproductexpirationdate";
            this.dateTimePicker_newproductexpirationdate.Size = new System.Drawing.Size(461, 39);
            this.dateTimePicker_newproductexpirationdate.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(188, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(498, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD THIS PRODUCT TO RAYON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_unitpricenew
            // 
            this.label_unitpricenew.AutoSize = true;
            this.label_unitpricenew.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_unitpricenew.ForeColor = System.Drawing.Color.Firebrick;
            this.label_unitpricenew.Location = new System.Drawing.Point(109, 415);
            this.label_unitpricenew.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_unitpricenew.Name = "label_unitpricenew";
            this.label_unitpricenew.Size = new System.Drawing.Size(191, 32);
            this.label_unitpricenew.TabIndex = 7;
            this.label_unitpricenew.Text = "UNIT PRICE:";
            // 
            // textBox_unitpricenew
            // 
            this.textBox_unitpricenew.BackColor = System.Drawing.Color.LightGray;
            this.textBox_unitpricenew.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_unitpricenew.Location = new System.Drawing.Point(310, 408);
            this.textBox_unitpricenew.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_unitpricenew.Name = "textBox_unitpricenew";
            this.textBox_unitpricenew.Size = new System.Drawing.Size(463, 39);
            this.textBox_unitpricenew.TabIndex = 8;
            // 
            // button_turnback
            // 
            this.button_turnback.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_turnback.ForeColor = System.Drawing.Color.Firebrick;
            this.button_turnback.Location = new System.Drawing.Point(15, 819);
            this.button_turnback.Margin = new System.Windows.Forms.Padding(6);
            this.button_turnback.Name = "button_turnback";
            this.button_turnback.Size = new System.Drawing.Size(269, 60);
            this.button_turnback.TabIndex = 9;
            this.button_turnback.Text = "◄ TURN BACK";
            this.button_turnback.UseVisualStyleBackColor = true;
            this.button_turnback.Click += new System.EventHandler(this.button_turnback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 145);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ADDNEWPRODUCTTORAYON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 914);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_turnback);
            this.Controls.Add(this.textBox_unitpricenew);
            this.Controls.Add(this.label_unitpricenew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_newproductexpirationdate);
            this.Controls.Add(this.textBox_newproductname);
            this.Controls.Add(this.textBox_newproductbarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDNEWPRODUCTTORAYON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD NEW PRODUCT TO RAYON";
            this.Load += new System.EventHandler(this.ADDNEWPRODUCTTORAYON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_newproductbarcode;
        private System.Windows.Forms.TextBox textBox_newproductname;
        private System.Windows.Forms.DateTimePicker dateTimePicker_newproductexpirationdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_unitpricenew;
        private System.Windows.Forms.TextBox textBox_unitpricenew;
        private System.Windows.Forms.Button button_turnback;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}