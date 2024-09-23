namespace WindowsFormsApp9
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
            this.chlDS = new System.Windows.Forms.CheckedListBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.lsvDsDaChon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ds cac mat hang";
            // 
            // chlDS
            // 
            this.chlDS.FormattingEnabled = true;
            this.chlDS.Items.AddRange(new object[] {
            "ban chai",
            "kem danh rang",
            "sua tam",
            "sua rua mat",
            "giau goi"});
            this.chlDS.Location = new System.Drawing.Point(52, 73);
            this.chlDS.Name = "chlDS";
            this.chlDS.Size = new System.Drawing.Size(148, 106);
            this.chlDS.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(52, 201);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(148, 31);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lsvDsDaChon
            // 
            this.lsvDsDaChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvDsDaChon.FullRowSelect = true;
            this.lsvDsDaChon.GridLines = true;
            this.lsvDsDaChon.HideSelection = false;
            this.lsvDsDaChon.Location = new System.Drawing.Point(266, 73);
            this.lsvDsDaChon.Name = "lsvDsDaChon";
            this.lsvDsDaChon.Size = new System.Drawing.Size(226, 159);
            this.lsvDsDaChon.TabIndex = 3;
            this.lsvDsDaChon.UseCompatibleStateImageBehavior = false;
            this.lsvDsDaChon.View = System.Windows.Forms.View.Details;
            this.lsvDsDaChon.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cac san pham da chon";
            this.columnHeader2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 343);
            this.Controls.Add(this.lsvDsDaChon);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.chlDS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chlDS;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ListView lsvDsDaChon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

