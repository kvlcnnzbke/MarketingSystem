
namespace WinFormsApp1
{
    partial class PURCHASINGDEPARTMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PURCHASINGDEPARTMENT));
            this.label_supplierid = new System.Windows.Forms.Label();
            this.label_suppliername = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_dateoforder = new System.Windows.Forms.Label();
            this.label_amountoforder = new System.Windows.Forms.Label();
            this.comboBox_supplerid = new System.Windows.Forms.ComboBox();
            this.textBox_suppliername = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_amountoforder = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_supplierid
            // 
            this.label_supplierid.AutoSize = true;
            this.label_supplierid.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_supplierid.ForeColor = System.Drawing.Color.Firebrick;
            this.label_supplierid.Location = new System.Drawing.Point(95, 113);
            this.label_supplierid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_supplierid.Name = "label_supplierid";
            this.label_supplierid.Size = new System.Drawing.Size(206, 32);
            this.label_supplierid.TabIndex = 0;
            this.label_supplierid.Text = "SUPPLIER ID:";
            // 
            // label_suppliername
            // 
            this.label_suppliername.AutoSize = true;
            this.label_suppliername.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_suppliername.ForeColor = System.Drawing.Color.Firebrick;
            this.label_suppliername.Location = new System.Drawing.Point(46, 197);
            this.label_suppliername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_suppliername.Name = "label_suppliername";
            this.label_suppliername.Size = new System.Drawing.Size(255, 32);
            this.label_suppliername.TabIndex = 1;
            this.label_suppliername.Text = "SUPPLIER NAME:";
            // 
            // label_dateoforder
            // 
            this.label_dateoforder.AutoSize = true;
            this.label_dateoforder.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dateoforder.ForeColor = System.Drawing.Color.Firebrick;
            this.label_dateoforder.Location = new System.Drawing.Point(38, 279);
            this.label_dateoforder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_dateoforder.Name = "label_dateoforder";
            this.label_dateoforder.Size = new System.Drawing.Size(263, 32);
            this.label_dateoforder.TabIndex = 2;
            this.label_dateoforder.Text = "DATE OF ORDER:";
            // 
            // label_amountoforder
            // 
            this.label_amountoforder.AutoSize = true;
            this.label_amountoforder.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_amountoforder.ForeColor = System.Drawing.Color.Firebrick;
            this.label_amountoforder.Location = new System.Drawing.Point(2, 467);
            this.label_amountoforder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_amountoforder.Name = "label_amountoforder";
            this.label_amountoforder.Size = new System.Drawing.Size(308, 32);
            this.label_amountoforder.TabIndex = 3;
            this.label_amountoforder.Text = "AMOUNT OF ORDER:";
            // 
            // comboBox_supplerid
            // 
            this.comboBox_supplerid.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_supplerid.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_supplerid.ForeColor = System.Drawing.Color.Black;
            this.comboBox_supplerid.FormattingEnabled = true;
            this.comboBox_supplerid.Location = new System.Drawing.Point(307, 105);
            this.comboBox_supplerid.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_supplerid.Name = "comboBox_supplerid";
            this.comboBox_supplerid.Size = new System.Drawing.Size(438, 40);
            this.comboBox_supplerid.TabIndex = 4;
            this.comboBox_supplerid.SelectedIndexChanged += new System.EventHandler(this.comboBox_supplerid_SelectedIndexChanged);
            // 
            // textBox_suppliername
            // 
            this.textBox_suppliername.BackColor = System.Drawing.Color.LightGray;
            this.textBox_suppliername.Enabled = false;
            this.textBox_suppliername.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_suppliername.ForeColor = System.Drawing.Color.Black;
            this.textBox_suppliername.Location = new System.Drawing.Point(307, 190);
            this.textBox_suppliername.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_suppliername.Name = "textBox_suppliername";
            this.textBox_suppliername.Size = new System.Drawing.Size(438, 39);
            this.textBox_suppliername.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(307, 272);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(438, 39);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox_amountoforder
            // 
            this.textBox_amountoforder.BackColor = System.Drawing.Color.LightGray;
            this.textBox_amountoforder.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_amountoforder.Location = new System.Drawing.Point(307, 460);
            this.textBox_amountoforder.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_amountoforder.Name = "textBox_amountoforder";
            this.textBox_amountoforder.Size = new System.Drawing.Size(438, 39);
            this.textBox_amountoforder.TabIndex = 7;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.Firebrick;
            this.button_update.Location = new System.Drawing.Point(208, 527);
            this.button_update.Margin = new System.Windows.Forms.Padding(6);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(438, 62);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "UPDATE AMOUNT OF ORDER";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.Color.Firebrick;
            this.button_delete.Location = new System.Drawing.Point(208, 613);
            this.button_delete.Margin = new System.Windows.Forms.Padding(6);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(438, 62);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 732);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(672, 320);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(307, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(208, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "UPDATE DATE OF ORDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PURCHASINGDEPARTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 1081);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_amountoforder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_suppliername);
            this.Controls.Add(this.comboBox_supplerid);
            this.Controls.Add(this.label_amountoforder);
            this.Controls.Add(this.label_dateoforder);
            this.Controls.Add(this.label_suppliername);
            this.Controls.Add(this.label_supplierid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PURCHASINGDEPARTMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PURCHASING DEPARTMENT";
            this.Load += new System.EventHandler(this.PURCHASINGDEPARTMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_supplierid;
        private System.Windows.Forms.Label label_suppliername;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_dateoforder;
        private System.Windows.Forms.Label label_amountoforder;
        private System.Windows.Forms.ComboBox comboBox_supplerid;
        private System.Windows.Forms.TextBox textBox_suppliername;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_amountoforder;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}