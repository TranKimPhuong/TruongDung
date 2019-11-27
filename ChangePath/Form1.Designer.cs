namespace ChangePath
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbDownload = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 42);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(310, 20);
            this.txtPath.TabIndex = 0;
            // 
            // lbDownload
            // 
            this.lbDownload.AutoSize = true;
            this.lbDownload.Location = new System.Drawing.Point(13, 21);
            this.lbDownload.Name = "lbDownload";
            this.lbDownload.Size = new System.Drawing.Size(87, 13);
            this.lbDownload.TabIndex = 1;
            this.lbDownload.Text = "Download Folder";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(91, 105);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(135, 25);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ex: D:\\Demo\\Download";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lbDownload);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lbDownload;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
    }
}

