namespace WindowsFormsApp29
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhomMonAn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDS = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDMonAN = new System.Windows.Forms.TextBox();
            this.txtIdNhomMonAn = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDvTInh = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnKoDung = new System.Windows.Forms.Button();
            this.btnCoDung = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trinh sua du lieu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "chon nhom mon an";
            // 
            // cboNhomMonAn
            // 
            this.cboNhomMonAn.FormattingEnabled = true;
            this.cboNhomMonAn.Location = new System.Drawing.Point(203, 55);
            this.cboNhomMonAn.Name = "cboNhomMonAn";
            this.cboNhomMonAn.Size = new System.Drawing.Size(253, 24);
            this.cboNhomMonAn.TabIndex = 2;
            this.cboNhomMonAn.SelectedIndexChanged += new System.EventHandler(this.cboNhomMonAn_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDS);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thong tin mon an";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCoDung);
            this.groupBox2.Controls.Add(this.btnKoDung);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtDvTInh);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.txtIdNhomMonAn);
            this.groupBox2.Controls.Add(this.txtIDMonAN);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(372, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 340);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chinh sua thong tin mon an";
            // 
            // lsvDS
            // 
            this.lsvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDS.FullRowSelect = true;
            this.lsvDS.GridLines = true;
            this.lsvDS.HideSelection = false;
            this.lsvDS.Location = new System.Drawing.Point(3, 18);
            this.lsvDS.Name = "lsvDS";
            this.lsvDS.Size = new System.Drawing.Size(348, 319);
            this.lsvDS.TabIndex = 0;
            this.lsvDS.UseCompatibleStateImageBehavior = false;
            this.lsvDS.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "id MA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID nhom mon an";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ten";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "dv Tinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "gia";
            // 
            // txtIDMonAN
            // 
            this.txtIDMonAN.Location = new System.Drawing.Point(65, 46);
            this.txtIDMonAN.Name = "txtIDMonAN";
            this.txtIDMonAN.Size = new System.Drawing.Size(100, 22);
            this.txtIDMonAN.TabIndex = 5;
            // 
            // txtIdNhomMonAn
            // 
            this.txtIdNhomMonAn.Location = new System.Drawing.Point(128, 92);
            this.txtIdNhomMonAn.Name = "txtIdNhomMonAn";
            this.txtIdNhomMonAn.Size = new System.Drawing.Size(100, 22);
            this.txtIdNhomMonAn.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(50, 142);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 7;
            // 
            // txtDvTInh
            // 
            this.txtDvTInh.Location = new System.Drawing.Point(76, 187);
            this.txtDvTInh.Name = "txtDvTInh";
            this.txtDvTInh.Size = new System.Drawing.Size(100, 22);
            this.txtDvTInh.TabIndex = 8;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(51, 243);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 9;
            // 
            // btnKoDung
            // 
            this.btnKoDung.Location = new System.Drawing.Point(21, 295);
            this.btnKoDung.Name = "btnKoDung";
            this.btnKoDung.Size = new System.Drawing.Size(98, 23);
            this.btnKoDung.TabIndex = 10;
            this.btnKoDung.Text = "k dung par";
            this.btnKoDung.UseVisualStyleBackColor = true;
            // 
            // btnCoDung
            // 
            this.btnCoDung.Location = new System.Drawing.Point(153, 295);
            this.btnCoDung.Name = "btnCoDung";
            this.btnCoDung.Size = new System.Drawing.Size(75, 23);
            this.btnCoDung.TabIndex = 11;
            this.btnCoDung.Text = "co dung";
            this.btnCoDung.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Mon";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id nhom mon";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ten";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "dvTinh";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "gia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboNhomMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhomMonAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCoDung;
        private System.Windows.Forms.Button btnKoDung;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDvTInh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtIdNhomMonAn;
        private System.Windows.Forms.TextBox txtIDMonAN;
    }
}

