namespace EpicorIntegration
{
    partial class Undo_Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Undo_Checkout));
            this.undo_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gid_txt = new System.Windows.Forms.TextBox();
            this.pnum_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rev_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // undo_btn
            // 
            this.undo_btn.Location = new System.Drawing.Point(172, 43);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(75, 23);
            this.undo_btn.TabIndex = 0;
            this.undo_btn.Text = "Undo";
            this.undo_btn.UseVisualStyleBackColor = true;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(172, 72);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group ID";
            // 
            // gid_txt
            // 
            this.gid_txt.Location = new System.Drawing.Point(15, 25);
            this.gid_txt.Name = "gid_txt";
            this.gid_txt.Size = new System.Drawing.Size(100, 20);
            this.gid_txt.TabIndex = 3;
            // 
            // pnum_txt
            // 
            this.pnum_txt.Location = new System.Drawing.Point(15, 64);
            this.pnum_txt.Name = "pnum_txt";
            this.pnum_txt.Size = new System.Drawing.Size(100, 20);
            this.pnum_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Part Number";
            // 
            // rev_txt
            // 
            this.rev_txt.Location = new System.Drawing.Point(121, 64);
            this.rev_txt.Name = "rev_txt";
            this.rev_txt.Size = new System.Drawing.Size(45, 20);
            this.rev_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Revision";
            // 
            // Undo_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 107);
            this.Controls.Add(this.rev_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnum_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gid_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.undo_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Undo_Checkout";
            this.Text = "Undo Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gid_txt;
        private System.Windows.Forms.TextBox pnum_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rev_txt;
        private System.Windows.Forms.Label label3;
    }
}