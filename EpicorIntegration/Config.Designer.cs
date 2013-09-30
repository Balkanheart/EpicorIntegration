namespace EpicorIntegration
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SeverPort = new System.Windows.Forms.TextBox();
            this.logininfobtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtlreseq_cbo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(9, 32);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(144, 20);
            this.ServerName.TabIndex = 0;
            this.ServerName.Text = "EPAPP1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SeverPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SeverPort
            // 
            this.SeverPort.Location = new System.Drawing.Point(9, 71);
            this.SeverPort.MaxLength = 5;
            this.SeverPort.Name = "SeverPort";
            this.SeverPort.Size = new System.Drawing.Size(60, 20);
            this.SeverPort.TabIndex = 2;
            this.SeverPort.Text = "9411";
            // 
            // logininfobtn
            // 
            this.logininfobtn.Location = new System.Drawing.Point(12, 187);
            this.logininfobtn.Name = "logininfobtn";
            this.logininfobtn.Size = new System.Drawing.Size(78, 23);
            this.logininfobtn.TabIndex = 3;
            this.logininfobtn.Text = "Login Info";
            this.logininfobtn.UseVisualStyleBackColor = true;
            this.logininfobtn.Click += new System.EventHandler(this.logininfobtn_click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(12, 216);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(93, 216);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtlreseq_cbo);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material Re-Sequence Type";
            // 
            // mtlreseq_cbo
            // 
            this.mtlreseq_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mtlreseq_cbo.FormattingEnabled = true;
            this.mtlreseq_cbo.Location = new System.Drawing.Point(6, 19);
            this.mtlreseq_cbo.Name = "mtlreseq_cbo";
            this.mtlreseq_cbo.Size = new System.Drawing.Size(144, 21);
            this.mtlreseq_cbo.TabIndex = 0;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.logininfobtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Config_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SeverPort;
        private System.Windows.Forms.Button logininfobtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox mtlreseq_cbo;
    }
}