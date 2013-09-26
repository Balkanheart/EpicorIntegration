namespace EpicorIntegration
{
    partial class Resource_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resource_Master));
            this.MajorHorizSplit = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resourcegrp_cbo = new System.Windows.Forms.ComboBox();
            this.resource_cbo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.operation_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gid_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rev_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partnumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.ResourceGrid = new System.Windows.Forms.DataGridView();
            this.ResourceGrpDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpDtlSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MajorHorizSplit)).BeginInit();
            this.MajorHorizSplit.Panel1.SuspendLayout();
            this.MajorHorizSplit.Panel2.SuspendLayout();
            this.MajorHorizSplit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorHorizSplit
            // 
            this.MajorHorizSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MajorHorizSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MajorHorizSplit.Location = new System.Drawing.Point(0, 0);
            this.MajorHorizSplit.Name = "MajorHorizSplit";
            this.MajorHorizSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MajorHorizSplit.Panel1
            // 
            this.MajorHorizSplit.Panel1.Controls.Add(this.groupBox2);
            this.MajorHorizSplit.Panel1.Controls.Add(this.operation_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label1);
            this.MajorHorizSplit.Panel1.Controls.Add(this.gid_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label5);
            this.MajorHorizSplit.Panel1.Controls.Add(this.rev_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label4);
            this.MajorHorizSplit.Panel1.Controls.Add(this.partnumber_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label2);
            this.MajorHorizSplit.Panel1.Controls.Add(this.groupBox1);
            // 
            // MajorHorizSplit.Panel2
            // 
            this.MajorHorizSplit.Panel2.Controls.Add(this.ResourceGrid);
            this.MajorHorizSplit.Size = new System.Drawing.Size(495, 292);
            this.MajorHorizSplit.SplitterDistance = 167;
            this.MajorHorizSplit.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.resourcegrp_cbo);
            this.groupBox2.Controls.Add(this.resource_cbo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 64);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Resource Group:";
            // 
            // resourcegrp_cbo
            // 
            this.resourcegrp_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourcegrp_cbo.FormattingEnabled = true;
            this.resourcegrp_cbo.Location = new System.Drawing.Point(9, 32);
            this.resourcegrp_cbo.Name = "resourcegrp_cbo";
            this.resourcegrp_cbo.Size = new System.Drawing.Size(196, 21);
            this.resourcegrp_cbo.TabIndex = 17;
            this.resourcegrp_cbo.SelectedIndexChanged += new System.EventHandler(this.resourcegrp_cbo_SelectedIndexChanged);
            // 
            // resource_cbo
            // 
            this.resource_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resource_cbo.FormattingEnabled = true;
            this.resource_cbo.Location = new System.Drawing.Point(211, 32);
            this.resource_cbo.Name = "resource_cbo";
            this.resource_cbo.Size = new System.Drawing.Size(160, 21);
            this.resource_cbo.TabIndex = 19;
            this.resource_cbo.SelectedIndexChanged += new System.EventHandler(this.resource_cbo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Resource:";
            // 
            // operation_txt
            // 
            this.operation_txt.Location = new System.Drawing.Point(87, 65);
            this.operation_txt.Name = "operation_txt";
            this.operation_txt.Size = new System.Drawing.Size(220, 20);
            this.operation_txt.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Operation:";
            // 
            // gid_txt
            // 
            this.gid_txt.Location = new System.Drawing.Point(87, 37);
            this.gid_txt.Name = "gid_txt";
            this.gid_txt.Size = new System.Drawing.Size(130, 20);
            this.gid_txt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Group ID:";
            // 
            // rev_txt
            // 
            this.rev_txt.Location = new System.Drawing.Point(259, 11);
            this.rev_txt.Name = "rev_txt";
            this.rev_txt.Size = new System.Drawing.Size(48, 20);
            this.rev_txt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rev:";
            // 
            // partnumber_txt
            // 
            this.partnumber_txt.Location = new System.Drawing.Point(87, 11);
            this.partnumber_txt.Name = "partnumber_txt";
            this.partnumber_txt.Size = new System.Drawing.Size(130, 20);
            this.partnumber_txt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Part Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Controls.Add(this.cancelbtn);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Location = new System.Drawing.Point(399, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 144);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(6, 19);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "&New";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(6, 77);
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
            this.savebtn.Location = new System.Drawing.Point(6, 48);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "&Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // ResourceGrid
            // 
            this.ResourceGrid.AllowUserToAddRows = false;
            this.ResourceGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResourceGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ResourceGrid.BackgroundColor = System.Drawing.Color.White;
            this.ResourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceGrpDesc,
            this.ResourceDesc,
            this.OpDtlSeq});
            this.ResourceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResourceGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ResourceGrid.Location = new System.Drawing.Point(0, 0);
            this.ResourceGrid.MultiSelect = false;
            this.ResourceGrid.Name = "ResourceGrid";
            this.ResourceGrid.ReadOnly = true;
            this.ResourceGrid.RowHeadersVisible = false;
            this.ResourceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResourceGrid.ShowCellErrors = false;
            this.ResourceGrid.ShowCellToolTips = false;
            this.ResourceGrid.ShowEditingIcon = false;
            this.ResourceGrid.ShowRowErrors = false;
            this.ResourceGrid.Size = new System.Drawing.Size(495, 121);
            this.ResourceGrid.TabIndex = 1;
            // 
            // ResourceGrpDesc
            // 
            this.ResourceGrpDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ResourceGrpDesc.DataPropertyName = "ResourceGrpDesc";
            this.ResourceGrpDesc.HeaderText = "Resource Group";
            this.ResourceGrpDesc.Name = "ResourceGrpDesc";
            this.ResourceGrpDesc.ReadOnly = true;
            this.ResourceGrpDesc.Width = 101;
            // 
            // ResourceDesc
            // 
            this.ResourceDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ResourceDesc.DataPropertyName = "ResourceDesc";
            this.ResourceDesc.HeaderText = "Resource";
            this.ResourceDesc.Name = "ResourceDesc";
            this.ResourceDesc.ReadOnly = true;
            this.ResourceDesc.Width = 78;
            // 
            // OpDtlSeq
            // 
            this.OpDtlSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpDtlSeq.HeaderText = "Description";
            this.OpDtlSeq.Name = "OpDtlSeq";
            this.OpDtlSeq.ReadOnly = true;
            // 
            // Resource_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(495, 292);
            this.Controls.Add(this.MajorHorizSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resource_Master";
            this.Text = "Add Resource To...";
            this.Load += new System.EventHandler(this.Resource_Master_Load);
            this.MajorHorizSplit.Panel1.ResumeLayout(false);
            this.MajorHorizSplit.Panel1.PerformLayout();
            this.MajorHorizSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MajorHorizSplit)).EndInit();
            this.MajorHorizSplit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResourceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MajorHorizSplit;
        private System.Windows.Forms.DataGridView ResourceGrid;
        private System.Windows.Forms.TextBox operation_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gid_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rev_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox partnumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox resource_cbo;
        private System.Windows.Forms.ComboBox resourcegrp_cbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceGrpDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpDtlSeq;
    }
}