namespace EpicorIntegration
{
    partial class Item_CopyFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_CopyFrom));
            this.template_cbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partnumber_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rev_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // template_cbo
            // 
            this.template_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.template_cbo.FormattingEnabled = true;
            this.template_cbo.Location = new System.Drawing.Point(15, 25);
            this.template_cbo.Name = "template_cbo";
            this.template_cbo.Size = new System.Drawing.Size(266, 21);
            this.template_cbo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Template:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Part Number:";
            // 
            // partnumber_txt
            // 
            this.partnumber_txt.Location = new System.Drawing.Point(9, 43);
            this.partnumber_txt.Name = "partnumber_txt";
            this.partnumber_txt.Size = new System.Drawing.Size(146, 20);
            this.partnumber_txt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.desc_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rev_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.partnumber_txt);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other";
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(9, 82);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(208, 20);
            this.desc_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // rev_txt
            // 
            this.rev_txt.Location = new System.Drawing.Point(163, 43);
            this.rev_txt.Name = "rev_txt";
            this.rev_txt.Size = new System.Drawing.Size(54, 20);
            this.rev_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rev.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "&New Template";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Use &Selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Item_CopyFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 217);
            this.Controls.Add(this.template_cbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Item_CopyFrom";
            this.Text = "Copy Item From...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox template_cbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partnumber_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rev_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}