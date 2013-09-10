namespace EpicorIntegration
{
    partial class EpicLogin
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
            this.AllWhitePanel = new System.Windows.Forms.Panel();
            this.EpicorLogo = new System.Windows.Forms.PictureBox();
            this.BlueLinePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.Passw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.AllWhitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpicorLogo)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllWhitePanel
            // 
            this.AllWhitePanel.BackColor = System.Drawing.Color.White;
            this.AllWhitePanel.Controls.Add(this.EpicorLogo);
            this.AllWhitePanel.Location = new System.Drawing.Point(0, 0);
            this.AllWhitePanel.Margin = new System.Windows.Forms.Padding(0);
            this.AllWhitePanel.Name = "AllWhitePanel";
            this.AllWhitePanel.Size = new System.Drawing.Size(384, 100);
            this.AllWhitePanel.TabIndex = 0;
            // 
            // EpicorLogo
            // 
            this.EpicorLogo.Image = global::EpicorIntegration.Properties.Resources.p1;
            this.EpicorLogo.Location = new System.Drawing.Point(65, 33);
            this.EpicorLogo.Name = "EpicorLogo";
            this.EpicorLogo.Size = new System.Drawing.Size(254, 44);
            this.EpicorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EpicorLogo.TabIndex = 1;
            this.EpicorLogo.TabStop = false;
            // 
            // BlueLinePanel
            // 
            this.BlueLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.BlueLinePanel.Location = new System.Drawing.Point(0, 101);
            this.BlueLinePanel.Name = "BlueLinePanel";
            this.BlueLinePanel.Size = new System.Drawing.Size(384, 10);
            this.BlueLinePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name:";
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(80, 3);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(100, 20);
            this.Uname.TabIndex = 0;
            // 
            // Passw
            // 
            this.Passw.Location = new System.Drawing.Point(80, 29);
            this.Passw.Name = "Passw";
            this.Passw.PasswordChar = '*';
            this.Passw.Size = new System.Drawing.Size(100, 20);
            this.Passw.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(16, 66);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "&Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(105, 66);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "&Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.Uname);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.Cancelbtn);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.Savebtn);
            this.ControlPanel.Controls.Add(this.Passw);
            this.ControlPanel.Location = new System.Drawing.Point(93, 117);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(200, 100);
            this.ControlPanel.TabIndex = 7;
            // 
            // EpicLogin
            // 
            this.AcceptButton = this.Savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(384, 227);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.BlueLinePanel);
            this.Controls.Add(this.AllWhitePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EpicLogin";
            this.Text = "Epicor Login";
            this.Load += new System.EventHandler(this.EpicLogin_Load);
            this.AllWhitePanel.ResumeLayout(false);
            this.AllWhitePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpicorLogo)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllWhitePanel;
        private System.Windows.Forms.PictureBox EpicorLogo;
        private System.Windows.Forms.Panel BlueLinePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox Passw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Panel ControlPanel;
    }
}