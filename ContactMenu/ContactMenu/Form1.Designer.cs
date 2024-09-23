namespace ContactMenu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.doiThanhMauDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiThanhMauXanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.doiThanhMauDenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiThanhMauDoToolStripMenuItem,
            this.doiThanhMauXanhToolStripMenuItem,
            this.toolStripSeparator1,
            this.doiThanhMauDenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 110);
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(41, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 124);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(285, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 124);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // doiThanhMauDoToolStripMenuItem
            // 
            this.doiThanhMauDoToolStripMenuItem.Name = "doiThanhMauDoToolStripMenuItem";
            this.doiThanhMauDoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.doiThanhMauDoToolStripMenuItem.Text = "doi thanh mau do";
            this.doiThanhMauDoToolStripMenuItem.Click += new System.EventHandler(this.doiThanhMauDoToolStripMenuItem_Click);
            // 
            // doiThanhMauXanhToolStripMenuItem
            // 
            this.doiThanhMauXanhToolStripMenuItem.Name = "doiThanhMauXanhToolStripMenuItem";
            this.doiThanhMauXanhToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.doiThanhMauXanhToolStripMenuItem.Text = "doi thanh mau xanh";
            this.doiThanhMauXanhToolStripMenuItem.Click += new System.EventHandler(this.doiThanhMauXanhToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // doiThanhMauDenToolStripMenuItem
            // 
            this.doiThanhMauDenToolStripMenuItem.Name = "doiThanhMauDenToolStripMenuItem";
            this.doiThanhMauDenToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.doiThanhMauDenToolStripMenuItem.Text = "doi thanh mau den";
            this.doiThanhMauDenToolStripMenuItem.Click += new System.EventHandler(this.doiThanhMauDenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiThanhMauDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiThanhMauXanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem doiThanhMauDenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

