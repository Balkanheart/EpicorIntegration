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
            this.gid_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rev_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partnumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prodstd_cbo = new System.Windows.Forms.ComboBox();
            this.resource_show = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.prodhrs_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opmast_cbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.OPDataGrid = new System.Windows.Forms.DataGridView();
            this.OprSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdformat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryResourceGrpDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MajorContainer)).BeginInit();
            this.MajorContainer.Panel1.SuspendLayout();
            this.MajorContainer.Panel2.SuspendLayout();
            this.MajorContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodhrs_num)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorContainer
            // 
            this.MajorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MajorContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MajorContainer.Location = new System.Drawing.Point(0, 0);
            this.MajorContainer.Name = "MajorContainer";
            this.MajorContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MajorContainer.Panel1
            // 
            this.MajorContainer.Panel1.Controls.Add(this.gid_txt);
            this.MajorContainer.Panel1.Controls.Add(this.label5);
            this.MajorContainer.Panel1.Controls.Add(this.rev_txt);
            this.MajorContainer.Panel1.Controls.Add(this.label4);
            this.MajorContainer.Panel1.Controls.Add(this.partnumber_txt);
            this.MajorContainer.Panel1.Controls.Add(this.label2);
            this.MajorContainer.Panel1.Controls.Add(this.groupBox2);
            this.MajorContainer.Panel1.Controls.Add(this.groupBox1);
            this.MajorContainer.Panel1MinSize = 177;
            // 
            // MajorContainer.Panel2
            // 
            this.MajorContainer.Panel2.Controls.Add(this.OPDataGrid);
            this.MajorContainer.Size = new System.Drawing.Size(584, 469);
            this.MajorContainer.SplitterDistance = 177;
            this.MajorContainer.TabIndex = 0;
            // 
            // gid_txt
            // 
            this.gid_txt.Location = new System.Drawing.Point(87, 35);
            this.gid_txt.Name = "gid_txt";
            this.gid_txt.Size = new System.Drawing.Size(130, 20);
            this.gid_txt.TabIndex = 13;
            this.gid_txt.Text = "tw";
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
            // rev_txt
            // 
            this.rev_txt.Location = new System.Drawing.Point(259, 9);
            this.rev_txt.Name = "rev_txt";
            this.rev_txt.Size = new System.Drawing.Size(48, 20);
            this.rev_txt.TabIndex = 11;
            this.rev_txt.Text = "d";
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
            // partnumber_txt
            // 
            this.partnumber_txt.Location = new System.Drawing.Point(87, 9);
            this.partnumber_txt.Name = "partnumber_txt";
            this.partnumber_txt.Size = new System.Drawing.Size(130, 20);
            this.partnumber_txt.TabIndex = 9;
            this.partnumber_txt.Text = "test12";
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
            this.groupBox2.Controls.Add(this.prodstd_cbo);
            this.groupBox2.Controls.Add(this.resource_show);
            this.groupBox2.Controls.Add(this.refresh_btn);
            this.groupBox2.Controls.Add(this.prodhrs_num);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.opmast_cbo);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 110);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // prodstd_cbo
            // 
            this.prodstd_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodstd_cbo.FormattingEnabled = true;
            this.prodstd_cbo.Location = new System.Drawing.Point(80, 77);
            this.prodstd_cbo.Name = "prodstd_cbo";
            this.prodstd_cbo.Size = new System.Drawing.Size(191, 21);
            this.prodstd_cbo.TabIndex = 9;
            this.prodstd_cbo.SelectedIndexChanged += new System.EventHandler(this.prodstd_cbo_SelectedIndexChanged);
            // 
            // resource_show
            // 
            this.resource_show.Location = new System.Drawing.Point(385, 19);
            this.resource_show.Name = "resource_show";
            this.resource_show.Size = new System.Drawing.Size(75, 23);
            this.resource_show.TabIndex = 1;
            this.resource_show.Text = "Resources";
            this.resource_show.UseVisualStyleBackColor = true;
            this.resource_show.Click += new System.EventHandler(this.resource_show_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(385, 48);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "&Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // prodhrs_num
            // 
            this.prodhrs_num.DecimalPlaces = 2;
            this.prodhrs_num.Location = new System.Drawing.Point(9, 78);
            this.prodhrs_num.Name = "prodhrs_num";
            this.prodhrs_num.Size = new System.Drawing.Size(65, 20);
            this.prodhrs_num.TabIndex = 8;
            this.prodhrs_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodhrs_num.ValueChanged += new System.EventHandler(this.prodhrs_num_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prod. Std:";
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
            this.opmast_cbo.Size = new System.Drawing.Size(262, 21);
            this.opmast_cbo.TabIndex = 4;
            this.opmast_cbo.SelectedIndexChanged += new System.EventHandler(this.opmast_cbo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newbtn);
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Controls.Add(this.cancelbtn);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Location = new System.Drawing.Point(484, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(6, 16);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "&New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(6, 74);
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
            this.cancelbtn.Location = new System.Drawing.Point(6, 134);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "&Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(6, 45);
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
            this.OPDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OprSeq,
            this.OpCode,
            this.OpDesc,
            this.ProdStandard,
            this.stdformat,
            this.PrimaryResourceGrpDesc});
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
            this.OPDataGrid.Size = new System.Drawing.Size(584, 288);
            this.OPDataGrid.TabIndex = 0;
            // 
            // OprSeq
            // 
            this.OprSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OprSeq.DataPropertyName = "OprSeq";
            this.OprSeq.HeaderText = "Sequence";
            this.OprSeq.Name = "OprSeq";
            this.OprSeq.ReadOnly = true;
            this.OprSeq.Width = 81;
            // 
            // OpCode
            // 
            this.OpCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OpCode.DataPropertyName = "OpCode";
            this.OpCode.HeaderText = "Code";
            this.OpCode.Name = "OpCode";
            this.OpCode.ReadOnly = true;
            this.OpCode.Width = 57;
            // 
            // OpDesc
            // 
            this.OpDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OpDesc.DataPropertyName = "OpDesc";
            this.OpDesc.HeaderText = "Operation Description";
            this.OpDesc.Name = "OpDesc";
            this.OpDesc.ReadOnly = true;
            this.OpDesc.Width = 123;
            // 
            // ProdStandard
            // 
            this.ProdStandard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProdStandard.DataPropertyName = "ProdStandard";
            this.ProdStandard.HeaderText = "Production Hours";
            this.ProdStandard.Name = "ProdStandard";
            this.ProdStandard.ReadOnly = true;
            this.ProdStandard.Width = 105;
            // 
            // stdformat
            // 
            this.stdformat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdformat.DataPropertyName = "stdformat";
            this.stdformat.HeaderText = "Std. Format";
            this.stdformat.Name = "stdformat";
            this.stdformat.ReadOnly = true;
            this.stdformat.Width = 79;
            // 
            // PrimaryResourceGrpDesc
            // 
            this.PrimaryResourceGrpDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrimaryResourceGrpDesc.DataPropertyName = "PrimaryResourceGrpDesc";
            this.PrimaryResourceGrpDesc.HeaderText = "Primary Resource Group";
            this.PrimaryResourceGrpDesc.Name = "PrimaryResourceGrpDesc";
            this.PrimaryResourceGrpDesc.ReadOnly = true;
            this.PrimaryResourceGrpDesc.Width = 134;
            // 
            // Operations_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(584, 469);
            this.Controls.Add(this.MajorContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 507);
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
            ((System.ComponentModel.ISupportInitialize)(this.prodhrs_num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OPDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MajorContainer;
        private System.Windows.Forms.ComboBox opmast_cbo;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button newbtn;
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
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.NumericUpDown prodhrs_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resource_show;
        private System.Windows.Forms.ComboBox prodstd_cbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdformat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryResourceGrpDesc;
    }
}