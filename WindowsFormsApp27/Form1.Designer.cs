namespace WindowsFormsApp27
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbNCC = new System.Windows.Forms.ListBox();
            this.lsvDonHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "bt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbNCC);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ds nha cung cap";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDonHang);
            this.groupBox2.Location = new System.Drawing.Point(379, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ds don dat hang theo nha cc";
            // 
            // lsbNCC
            // 
            this.lsbNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbNCC.FormattingEnabled = true;
            this.lsbNCC.ItemHeight = 16;
            this.lsbNCC.Location = new System.Drawing.Point(3, 18);
            this.lsbNCC.Name = "lsbNCC";
            this.lsbNCC.Size = new System.Drawing.Size(339, 359);
            this.lsbNCC.TabIndex = 0;
            this.lsbNCC.SelectedIndexChanged += new System.EventHandler(this.lsbNCC_SelectedIndexChanged);
            // 
            // lsvDonHang
            // 
            this.lsvDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDonHang.FullRowSelect = true;
            this.lsvDonHang.GridLines = true;
            this.lsvDonHang.HideSelection = false;
            this.lsvDonHang.Location = new System.Drawing.Point(3, 18);
            this.lsvDonHang.Name = "lsvDonHang";
            this.lsvDonHang.Size = new System.Drawing.Size(403, 359);
            this.lsvDonHang.TabIndex = 0;
            this.lsvDonHang.UseCompatibleStateImageBehavior = false;
            this.lsvDonHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "so don hang";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ngay dat hang";
            this.columnHeader2.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDonHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

