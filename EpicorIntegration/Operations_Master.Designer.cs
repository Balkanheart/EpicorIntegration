namespace EpicorIntegration
{
    partial class Operations_Master
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operations_Master));
            this.MajorContainer = new System.Windows.Forms.SplitContainer();
            this.partnumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opmast_cbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.OPDataGrid = new System.Windows.Forms.DataGridView();
            this.rev_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gid_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MajorContainer)).BeginInit();
            this.MajorContainer.Panel1.SuspendLayout();
            this.MajorContainer.Panel2.SuspendLayout();
            this.MajorContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorContainer
            // 
            this.MajorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MajorContainer.Location = new System.Drawing.Point(0, 0);
            this.MajorContainer.Name = "MajorContainer";
            this.MajorContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MajorContainer.Panel1
            // 
            this.MajorContainer.Panel1.Controls.Add(this.button1);
            this.MajorContainer.Panel1.Controls.Add(this.gid_txt);
            this.MajorContainer.Panel1.Controls.Add(this.label5);
            this.MajorContainer.Panel1.Controls.Add(this.rev_txt);
            this.MajorContainer.Panel1.Controls.Add(this.label4);
            this.MajorContainer.Panel1.Controls.Add(this.partnumber_txt);
            this.MajorContainer.Panel1.Controls.Add(this.label2);
            this.MajorContainer.Panel1.Controls.Add(this.groupBox2);
            this.MajorContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // MajorContainer.Panel2
            // 
            this.MajorContainer.Panel2.Controls.Add(this.OPDataGrid);
            this.MajorContainer.Size = new System.Drawing.Size(498, 487);
            this.MajorContainer.SplitterDistance = 189;
            this.MajorContainer.TabIndex = 0;
            // 
            // partnumber_txt
            // 
            this.partnumber_txt.Location = new System.Drawing.Point(87, 9);
            this.partnumber_txt.Name = "partnumber_txt";
            this.partnumber_txt.Size = new System.Drawing.Size(130, 20);
            this.partnumber_txt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Part Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.opmast_cbo);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operation:";
            // 
            // opmast_cbo
            // 
            this.opmast_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opmast_cbo.FormattingEnabled = true;
            this.opmast_cbo.Location = new System.Drawing.Point(9, 32);
            this.opmast_cbo.Name = "opmast_cbo";
            this.opmast_cbo.Size = new System.Drawing.Size(196, 21);
            this.opmast_cbo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Controls.Add(this.cancelbtn);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Location = new System.Drawing.Point(398, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(6, 19);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "&Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(6, 48);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(75, 23);
            this.removebtn.TabIndex = 1;
            this.removebtn.Text = "&Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(6, 106);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "&Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(6, 77);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "&Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // OPDataGrid
            // 
            this.OPDataGrid.AllowUserToAddRows = false;
            this.OPDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OPDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OPDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OPDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OPDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OPDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OPDataGrid.Location = new System.Drawing.Point(0, 0);
            this.OPDataGrid.MultiSelect = false;
            this.OPDataGrid.Name = "OPDataGrid";
            this.OPDataGrid.ReadOnly = true;
            this.OPDataGrid.RowHeadersVisible = false;
            this.OPDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OPDataGrid.ShowCellErrors = false;
            this.OPDataGrid.ShowCellToolTips = false;
            this.OPDataGrid.ShowEditingIcon = false;
            this.OPDataGrid.ShowRowErrors = false;
            this.OPDataGrid.Size = new System.Drawing.Size(498, 294);
            this.OPDataGrid.TabIndex = 0;
            // 
            // rev_txt
            // 
            this.rev_txt.Location = new System.Drawing.Point(259, 9);
            this.rev_txt.Name = "rev_txt";
            this.rev_txt.Size = new System.Drawing.Size(48, 20);
            this.rev_txt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rev:";
            // 
            // gid_txt
            // 
            this.gid_txt.Location = new System.Drawing.Point(87, 35);
            this.gid_txt.Name = "gid_txt";
            this.gid_txt.Size = new System.Drawing.Size(130, 20);
            this.gid_txt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Group ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prod. Hours:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(75, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Operations_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(498, 487);
            this.Controls.Add(this.MajorContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operations_Master";
            this.Text = "Operations_Master";
            this.Load += new System.EventHandler(this.Operations_Master_Load);
            this.MajorContainer.Panel1.ResumeLayout(false);
            this.MajorContainer.Panel1.PerformLayout();
            this.MajorContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MajorContainer)).EndInit();
            this.MajorContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OPDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MajorContainer;
        private System.Windows.Forms.ComboBox opmast_cbo;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView OPDataGrid;
        private System.Windows.Forms.TextBox partnumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rev_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gid_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
    }
}