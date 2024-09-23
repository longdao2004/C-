namespace bt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThemNodeCha = new System.Windows.Forms.TextBox();
            this.btnThemNodeCha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThemNodeCon = new System.Windows.Forms.TextBox();
            this.btnThemNodeCon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuaNode = new System.Windows.Forms.TextBox();
            this.btnSuaNode = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnXoaNode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree View";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 475);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(203, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 475);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin nut";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 18);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 454);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemNodeCon);
            this.groupBox3.Controls.Add(this.txtThemNodeCon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnThemNodeCha);
            this.groupBox3.Controls.Add(this.txtThemNodeCha);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 136);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Them nut cha";
            // 
            // txtThemNodeCha
            // 
            this.txtThemNodeCha.Location = new System.Drawing.Point(131, 29);
            this.txtThemNodeCha.Name = "txtThemNodeCha";
            this.txtThemNodeCha.Size = new System.Drawing.Size(193, 22);
            this.txtThemNodeCha.TabIndex = 1;
            // 
            // btnThemNodeCha
            // 
            this.btnThemNodeCha.Location = new System.Drawing.Point(350, 33);
            this.btnThemNodeCha.Name = "btnThemNodeCha";
            this.btnThemNodeCha.Size = new System.Drawing.Size(113, 23);
            this.btnThemNodeCha.TabIndex = 2;
            this.btnThemNodeCha.Text = "Them nut cha";
            this.btnThemNodeCha.UseVisualStyleBackColor = true;
            this.btnThemNodeCha.Click += new System.EventHandler(this.btnThemNodeCha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Them nut con";
            // 
            // txtThemNodeCon
            // 
            this.txtThemNodeCon.Location = new System.Drawing.Point(131, 82);
            this.txtThemNodeCon.Name = "txtThemNodeCon";
            this.txtThemNodeCon.Size = new System.Drawing.Size(193, 22);
            this.txtThemNodeCon.TabIndex = 4;
            // 
            // btnThemNodeCon
            // 
            this.btnThemNodeCon.Location = new System.Drawing.Point(350, 82);
            this.btnThemNodeCon.Name = "btnThemNodeCon";
            this.btnThemNodeCon.Size = new System.Drawing.Size(113, 23);
            this.btnThemNodeCon.TabIndex = 5;
            this.btnThemNodeCon.Text = "Them nut con";
            this.btnThemNodeCon.UseVisualStyleBackColor = true;
            this.btnThemNodeCon.Click += new System.EventHandler(this.btnThemNodeCon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSuaNode);
            this.groupBox4.Controls.Add(this.txtSuaNode);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sua node";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thong tin node";
            // 
            // txtSuaNode
            // 
            this.txtSuaNode.Location = new System.Drawing.Point(131, 45);
            this.txtSuaNode.Name = "txtSuaNode";
            this.txtSuaNode.Size = new System.Drawing.Size(193, 22);
            this.txtSuaNode.TabIndex = 1;
            // 
            // btnSuaNode
            // 
            this.btnSuaNode.Location = new System.Drawing.Point(350, 44);
            this.btnSuaNode.Name = "btnSuaNode";
            this.btnSuaNode.Size = new System.Drawing.Size(113, 23);
            this.btnSuaNode.TabIndex = 2;
            this.btnSuaNode.Text = "Sua node";
            this.btnSuaNode.UseVisualStyleBackColor = true;
            this.btnSuaNode.Click += new System.EventHandler(this.btnSuaNode_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXoaNode);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 254);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(591, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Xoa Node";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDuongDan);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 354);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(591, 118);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Duong dan";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDuongDan.Location = new System.Drawing.Point(3, 18);
            this.txtDuongDan.Multiline = true;
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(585, 97);
            this.txtDuongDan.TabIndex = 1;
            // 
            // btnXoaNode
            // 
            this.btnXoaNode.Location = new System.Drawing.Point(131, 32);
            this.btnXoaNode.Name = "btnXoaNode";
            this.btnXoaNode.Size = new System.Drawing.Size(221, 30);
            this.btnXoaNode.TabIndex = 3;
            this.btnXoaNode.Text = "Xoa node";
            this.btnXoaNode.UseVisualStyleBackColor = true;
            this.btnXoaNode.Click += new System.EventHandler(this.btnXoaNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemNodeCha;
        private System.Windows.Forms.TextBox txtThemNodeCha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSuaNode;
        private System.Windows.Forms.TextBox txtSuaNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemNodeCon;
        private System.Windows.Forms.TextBox txtThemNodeCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaNode;
    }
}

