namespace WindowsFormsApp4
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radPurple = new System.Windows.Forms.RadioButton();
            this.radBalck = new System.Windows.Forms.RadioButton();
            this.checkItalic = new System.Windows.Forms.CheckBox();
            this.checkUnderline = new System.Windows.Forms.CheckBox();
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noi dung";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(80, 13);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(243, 22);
            this.txtData.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBalck);
            this.groupBox1.Controls.Add(this.radPurple);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chon mau chu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBold);
            this.groupBox2.Controls.Add(this.checkUnderline);
            this.groupBox2.Controls.Add(this.checkItalic);
            this.groupBox2.Location = new System.Drawing.Point(275, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chon kieu chu";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(7, 22);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(73, 20);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "mau do";
            this.radRed.UseVisualStyleBackColor = false;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(7, 49);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(85, 20);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "mau xanh";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radPurple
            // 
            this.radPurple.AutoSize = true;
            this.radPurple.ForeColor = System.Drawing.Color.Purple;
            this.radPurple.Location = new System.Drawing.Point(7, 76);
            this.radPurple.Name = "radPurple";
            this.radPurple.Size = new System.Drawing.Size(74, 20);
            this.radPurple.TabIndex = 2;
            this.radPurple.TabStop = true;
            this.radPurple.Text = "mau tim";
            this.radPurple.UseVisualStyleBackColor = true;
            this.radPurple.CheckedChanged += new System.EventHandler(this.radPurple_CheckedChanged);
            // 
            // radBalck
            // 
            this.radBalck.AutoSize = true;
            this.radBalck.ForeColor = System.Drawing.Color.Black;
            this.radBalck.Location = new System.Drawing.Point(7, 103);
            this.radBalck.Name = "radBalck";
            this.radBalck.Size = new System.Drawing.Size(80, 20);
            this.radBalck.TabIndex = 3;
            this.radBalck.TabStop = true;
            this.radBalck.Text = "mau den";
            this.radBalck.UseVisualStyleBackColor = true;
            this.radBalck.CheckedChanged += new System.EventHandler(this.radBalck_CheckedChanged);
            // 
            // checkItalic
            // 
            this.checkItalic.AutoSize = true;
            this.checkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkItalic.Location = new System.Drawing.Point(6, 49);
            this.checkItalic.Name = "checkItalic";
            this.checkItalic.Size = new System.Drawing.Size(114, 20);
            this.checkItalic.TabIndex = 0;
            this.checkItalic.Text = "chu in nghieng";
            this.checkItalic.UseVisualStyleBackColor = true;
            // 
            // checkUnderline
            // 
            this.checkUnderline.AutoSize = true;
            this.checkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnderline.Location = new System.Drawing.Point(6, 75);
            this.checkUnderline.Name = "checkUnderline";
            this.checkUnderline.Size = new System.Drawing.Size(133, 20);
            this.checkUnderline.TabIndex = 1;
            this.checkUnderline.Text = "chu co gach chan";
            this.checkUnderline.UseVisualStyleBackColor = true;
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBold.Location = new System.Drawing.Point(6, 23);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(87, 20);
            this.checkBold.TabIndex = 2;
            this.checkBold.Text = "chu dam";
            this.checkBold.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBalck;
        private System.Windows.Forms.RadioButton radPurple;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBold;
        private System.Windows.Forms.CheckBox checkUnderline;
        private System.Windows.Forms.CheckBox checkItalic;
    }
}

