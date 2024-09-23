namespace WindowsFormsApp35
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDvTinh = new System.Windows.Forms.TextBox();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.quanlybanhangDataSet = new WindowsFormsApp35.QuanlybanhangDataSet();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUTableAdapter = new WindowsFormsApp35.QuanlybanhangDataSetTableAdapters.VATTUTableAdapter();
            this.maVTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPhanTram);
            this.splitContainer1.Panel2.Controls.Add(this.txtDvTinh);
            this.splitContainer1.Panel2.Controls.Add(this.txtTen);
            this.splitContainer1.Panel2.Controls.Add(this.txtMa);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVTuDataGridViewTextBoxColumn,
            this.tenVTuDataGridViewTextBoxColumn,
            this.dvTinhDataGridViewTextBoxColumn,
            this.phanTramDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vATTUBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ma vat tu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ten vat tu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "phan tram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "don vi tinh ";
            // 
            // txtMa
            // 
            this.txtMa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "MaVTu", true));
            this.txtMa.Location = new System.Drawing.Point(148, 53);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 22);
            this.txtMa.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "TenVTu", true));
            this.txtTen.Location = new System.Drawing.Point(148, 138);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 5;
            // 
            // txtDvTinh
            // 
            this.txtDvTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "DvTinh", true));
            this.txtDvTinh.Location = new System.Drawing.Point(148, 228);
            this.txtDvTinh.Name = "txtDvTinh";
            this.txtDvTinh.Size = new System.Drawing.Size(100, 22);
            this.txtDvTinh.TabIndex = 6;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "PhanTram", true));
            this.txtPhanTram.Location = new System.Drawing.Point(149, 318);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(100, 22);
            this.txtPhanTram.TabIndex = 7;
            // 
            // quanlybanhangDataSet
            // 
            this.quanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.quanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.quanlybanhangDataSet;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // maVTuDataGridViewTextBoxColumn
            // 
            this.maVTuDataGridViewTextBoxColumn.DataPropertyName = "MaVTu";
            this.maVTuDataGridViewTextBoxColumn.HeaderText = "MaVTu";
            this.maVTuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maVTuDataGridViewTextBoxColumn.Name = "maVTuDataGridViewTextBoxColumn";
            this.maVTuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenVTuDataGridViewTextBoxColumn
            // 
            this.tenVTuDataGridViewTextBoxColumn.DataPropertyName = "TenVTu";
            this.tenVTuDataGridViewTextBoxColumn.HeaderText = "TenVTu";
            this.tenVTuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenVTuDataGridViewTextBoxColumn.Name = "tenVTuDataGridViewTextBoxColumn";
            this.tenVTuDataGridViewTextBoxColumn.Width = 125;
            // 
            // dvTinhDataGridViewTextBoxColumn
            // 
            this.dvTinhDataGridViewTextBoxColumn.DataPropertyName = "DvTinh";
            this.dvTinhDataGridViewTextBoxColumn.HeaderText = "DvTinh";
            this.dvTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dvTinhDataGridViewTextBoxColumn.Name = "dvTinhDataGridViewTextBoxColumn";
            this.dvTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // phanTramDataGridViewTextBoxColumn
            // 
            this.phanTramDataGridViewTextBoxColumn.DataPropertyName = "PhanTram";
            this.phanTramDataGridViewTextBoxColumn.HeaderText = "PhanTram";
            this.phanTramDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phanTramDataGridViewTextBoxColumn.Name = "phanTramDataGridViewTextBoxColumn";
            this.phanTramDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.TextBox txtDvTinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private QuanlybanhangDataSetTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTramDataGridViewTextBoxColumn;
    }
}

