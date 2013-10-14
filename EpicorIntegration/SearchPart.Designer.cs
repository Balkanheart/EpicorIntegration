namespace EpicorIntegration
{
    partial class SearchPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPart));
            this.tabs = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.basicgroup = new System.Windows.Forms.GroupBox();
            this.group_cbo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.type_cbo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.status_cbo = new System.Windows.Forms.ComboBox();
            this.sortby_cbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.Advanced = new System.Windows.Forms.TabPage();
            this.advSplit = new System.Windows.Forms.SplitContainer();
            this.AdvSearch = new System.Windows.Forms.CheckBox();
            this.advgroup = new System.Windows.Forms.GroupBox();
            this.serial_chk = new System.Windows.Forms.CheckBox();
            this.onhold_chk = new System.Windows.Forms.CheckBox();
            this.phantom_chk = new System.Windows.Forms.CheckBox();
            this.qtybearing_chk = new System.Windows.Forms.CheckBox();
            this.nonstock_chk = new System.Windows.Forms.CheckBox();
            this.SearchResultGrid = new System.Windows.Forms.DataGridView();
            this.HorizMajorContainer = new System.Windows.Forms.SplitContainer();
            this.VerticalTopContainer = new System.Windows.Forms.SplitContainer();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.PartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PhantomBOM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TrackSerialNum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QtyBearing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabs.SuspendLayout();
            this.Basic.SuspendLayout();
            this.basicgroup.SuspendLayout();
            this.Advanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advSplit)).BeginInit();
            this.advSplit.Panel1.SuspendLayout();
            this.advSplit.Panel2.SuspendLayout();
            this.advSplit.SuspendLayout();
            this.advgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizMajorContainer)).BeginInit();
            this.HorizMajorContainer.Panel1.SuspendLayout();
            this.HorizMajorContainer.Panel2.SuspendLayout();
            this.HorizMajorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalTopContainer)).BeginInit();
            this.VerticalTopContainer.Panel1.SuspendLayout();
            this.VerticalTopContainer.Panel2.SuspendLayout();
            this.VerticalTopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.Basic);
            this.tabs.Controls.Add(this.Advanced);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.HotTrack = true;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(536, 162);
            this.tabs.TabIndex = 0;
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.SystemColors.Control;
            this.Basic.Controls.Add(this.basicgroup);
            this.Basic.Location = new System.Drawing.Point(4, 22);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(528, 136);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "Basic";
            // 
            // basicgroup
            // 
            this.basicgroup.BackColor = System.Drawing.SystemColors.Control;
            this.basicgroup.Controls.Add(this.group_cbo);
            this.basicgroup.Controls.Add(this.label5);
            this.basicgroup.Controls.Add(this.label4);
            this.basicgroup.Controls.Add(this.type_cbo);
            this.basicgroup.Controls.Add(this.label6);
            this.basicgroup.Controls.Add(this.status_cbo);
            this.basicgroup.Controls.Add(this.sortby_cbo);
            this.basicgroup.Controls.Add(this.label3);
            this.basicgroup.Controls.Add(this.label2);
            this.basicgroup.Controls.Add(this.Description);
            this.basicgroup.Controls.Add(this.label1);
            this.basicgroup.Controls.Add(this.PartNumber);
            this.basicgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicgroup.Location = new System.Drawing.Point(3, 3);
            this.basicgroup.Name = "basicgroup";
            this.basicgroup.Size = new System.Drawing.Size(522, 130);
            this.basicgroup.TabIndex = 3;
            this.basicgroup.TabStop = false;
            // 
            // group_cbo
            // 
            this.group_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cbo.FormattingEnabled = true;
            this.group_cbo.Location = new System.Drawing.Point(366, 39);
            this.group_cbo.Name = "group_cbo";
            this.group_cbo.Size = new System.Drawing.Size(148, 21);
            this.group_cbo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type Code:";
            // 
            // type_cbo
            // 
            this.type_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cbo.FormattingEnabled = true;
            this.type_cbo.Location = new System.Drawing.Point(366, 12);
            this.type_cbo.Name = "type_cbo";
            this.type_cbo.Size = new System.Drawing.Size(148, 21);
            this.type_cbo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // status_cbo
            // 
            this.status_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cbo.FormattingEnabled = true;
            this.status_cbo.Items.AddRange(new object[] {
            "Any",
            "Active",
            "Inactive"});
            this.status_cbo.Location = new System.Drawing.Point(125, 92);
            this.status_cbo.Name = "status_cbo";
            this.status_cbo.Size = new System.Drawing.Size(167, 21);
            this.status_cbo.TabIndex = 4;
            // 
            // sortby_cbo
            // 
            this.sortby_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortby_cbo.FormattingEnabled = true;
            this.sortby_cbo.Items.AddRange(new object[] {
            "Part Number",
            "Description",
            "Search Word"});
            this.sortby_cbo.Location = new System.Drawing.Point(125, 65);
            this.sortby_cbo.Name = "sortby_cbo";
            this.sortby_cbo.Size = new System.Drawing.Size(167, 21);
            this.sortby_cbo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description Contains:";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(125, 39);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(167, 20);
            this.Description.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Part Number Contains:";
            // 
            // PartNumber
            // 
            this.PartNumber.Location = new System.Drawing.Point(125, 13);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(167, 20);
            this.PartNumber.TabIndex = 1;
            // 
            // Advanced
            // 
            this.Advanced.BackColor = System.Drawing.SystemColors.Control;
            this.Advanced.Controls.Add(this.advSplit);
            this.Advanced.Location = new System.Drawing.Point(4, 22);
            this.Advanced.Name = "Advanced";
            this.Advanced.Padding = new System.Windows.Forms.Padding(3);
            this.Advanced.Size = new System.Drawing.Size(528, 136);
            this.Advanced.TabIndex = 1;
            this.Advanced.Text = "Advanced";
            // 
            // advSplit
            // 
            this.advSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advSplit.Location = new System.Drawing.Point(3, 3);
            this.advSplit.Name = "advSplit";
            this.advSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // advSplit.Panel1
            // 
            this.advSplit.Panel1.Controls.Add(this.AdvSearch);
            this.advSplit.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advSplit.Panel1MinSize = 17;
            // 
            // advSplit.Panel2
            // 
            this.advSplit.Panel2.Controls.Add(this.advgroup);
            this.advSplit.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advSplit.Size = new System.Drawing.Size(522, 130);
            this.advSplit.SplitterDistance = 25;
            this.advSplit.TabIndex = 0;
            // 
            // AdvSearch
            // 
            this.AdvSearch.AutoSize = true;
            this.AdvSearch.Location = new System.Drawing.Point(3, 3);
            this.AdvSearch.Name = "AdvSearch";
            this.AdvSearch.Size = new System.Drawing.Size(112, 17);
            this.AdvSearch.TabIndex = 0;
            this.AdvSearch.Text = "Advanced Search";
            this.AdvSearch.UseVisualStyleBackColor = true;
            this.AdvSearch.CheckedChanged += new System.EventHandler(this.AdvSearch_CheckedChanged);
            // 
            // advgroup
            // 
            this.advgroup.Controls.Add(this.serial_chk);
            this.advgroup.Controls.Add(this.onhold_chk);
            this.advgroup.Controls.Add(this.phantom_chk);
            this.advgroup.Controls.Add(this.qtybearing_chk);
            this.advgroup.Controls.Add(this.nonstock_chk);
            this.advgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advgroup.Enabled = false;
            this.advgroup.Location = new System.Drawing.Point(0, 0);
            this.advgroup.Name = "advgroup";
            this.advgroup.Size = new System.Drawing.Size(522, 101);
            this.advgroup.TabIndex = 0;
            this.advgroup.TabStop = false;
            // 
            // serial_chk
            // 
            this.serial_chk.AutoSize = true;
            this.serial_chk.Location = new System.Drawing.Point(112, 16);
            this.serial_chk.Name = "serial_chk";
            this.serial_chk.Size = new System.Drawing.Size(71, 17);
            this.serial_chk.TabIndex = 7;
            this.serial_chk.Text = "Serialized";
            this.serial_chk.UseVisualStyleBackColor = true;
            // 
            // onhold_chk
            // 
            this.onhold_chk.AutoSize = true;
            this.onhold_chk.Location = new System.Drawing.Point(189, 16);
            this.onhold_chk.Name = "onhold_chk";
            this.onhold_chk.Size = new System.Drawing.Size(65, 17);
            this.onhold_chk.TabIndex = 5;
            this.onhold_chk.Text = "On Hold";
            this.onhold_chk.UseVisualStyleBackColor = true;
            // 
            // phantom_chk
            // 
            this.phantom_chk.AutoSize = true;
            this.phantom_chk.Location = new System.Drawing.Point(6, 39);
            this.phantom_chk.Name = "phantom_chk";
            this.phantom_chk.Size = new System.Drawing.Size(95, 17);
            this.phantom_chk.TabIndex = 4;
            this.phantom_chk.Text = "Phantom BOM";
            this.phantom_chk.UseVisualStyleBackColor = true;
            this.phantom_chk.Visible = false;
            // 
            // qtybearing_chk
            // 
            this.qtybearing_chk.AutoSize = true;
            this.qtybearing_chk.Location = new System.Drawing.Point(112, 39);
            this.qtybearing_chk.Name = "qtybearing_chk";
            this.qtybearing_chk.Size = new System.Drawing.Size(81, 17);
            this.qtybearing_chk.TabIndex = 3;
            this.qtybearing_chk.Text = "Qty Bearing";
            this.qtybearing_chk.UseVisualStyleBackColor = true;
            this.qtybearing_chk.Visible = false;
            // 
            // nonstock_chk
            // 
            this.nonstock_chk.AutoSize = true;
            this.nonstock_chk.Location = new System.Drawing.Point(6, 16);
            this.nonstock_chk.Name = "nonstock_chk";
            this.nonstock_chk.Size = new System.Drawing.Size(100, 17);
            this.nonstock_chk.TabIndex = 2;
            this.nonstock_chk.Text = "Non-Stock Item";
            this.nonstock_chk.UseVisualStyleBackColor = true;
            // 
            // SearchResultGrid
            // 
            this.SearchResultGrid.AllowUserToAddRows = false;
            this.SearchResultGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchResultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SearchResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNum,
            this.PartDescription,
            this.TypeCode,
            this.ProdCode,
            this.SearchWord,
            this.ClassID,
            this.Inactive,
            this.PhantomBOM,
            this.TrackSerialNum,
            this.QtyBearing});
            this.SearchResultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultGrid.Location = new System.Drawing.Point(0, 0);
            this.SearchResultGrid.Name = "SearchResultGrid";
            this.SearchResultGrid.ReadOnly = true;
            this.SearchResultGrid.RowHeadersVisible = false;
            this.SearchResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultGrid.ShowCellErrors = false;
            this.SearchResultGrid.ShowCellToolTips = false;
            this.SearchResultGrid.ShowEditingIcon = false;
            this.SearchResultGrid.ShowRowErrors = false;
            this.SearchResultGrid.Size = new System.Drawing.Size(684, 196);
            this.SearchResultGrid.TabIndex = 0;
            // 
            // HorizMajorContainer
            // 
            this.HorizMajorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizMajorContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HorizMajorContainer.Location = new System.Drawing.Point(0, 0);
            this.HorizMajorContainer.Name = "HorizMajorContainer";
            this.HorizMajorContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizMajorContainer.Panel1
            // 
            this.HorizMajorContainer.Panel1.Controls.Add(this.VerticalTopContainer);
            this.HorizMajorContainer.Panel1MinSize = 162;
            // 
            // HorizMajorContainer.Panel2
            // 
            this.HorizMajorContainer.Panel2.Controls.Add(this.SearchResultGrid);
            this.HorizMajorContainer.Size = new System.Drawing.Size(684, 362);
            this.HorizMajorContainer.SplitterDistance = 162;
            this.HorizMajorContainer.TabIndex = 1;
            // 
            // VerticalTopContainer
            // 
            this.VerticalTopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalTopContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.VerticalTopContainer.Location = new System.Drawing.Point(0, 0);
            this.VerticalTopContainer.Name = "VerticalTopContainer";
            // 
            // VerticalTopContainer.Panel1
            // 
            this.VerticalTopContainer.Panel1.Controls.Add(this.tabs);
            this.VerticalTopContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // VerticalTopContainer.Panel2
            // 
            this.VerticalTopContainer.Panel2.Controls.Add(this.OptionsBtn);
            this.VerticalTopContainer.Panel2.Controls.Add(this.Clearbtn);
            this.VerticalTopContainer.Panel2.Controls.Add(this.CancelBtn);
            this.VerticalTopContainer.Panel2.Controls.Add(this.SearchBtn);
            this.VerticalTopContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VerticalTopContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VerticalTopContainer.Size = new System.Drawing.Size(684, 162);
            this.VerticalTopContainer.SplitterDistance = 536;
            this.VerticalTopContainer.TabIndex = 2;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Location = new System.Drawing.Point(12, 70);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(117, 23);
            this.OptionsBtn.TabIndex = 5;
            this.OptionsBtn.Text = "&Options";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(12, 41);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(117, 23);
            this.Clearbtn.TabIndex = 3;
            this.Clearbtn.Text = "&Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(12, 99);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(117, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(12, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(117, 23);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "&Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // PartNum
            // 
            this.PartNum.DataPropertyName = "PartNum";
            this.PartNum.HeaderText = "Part Number";
            this.PartNum.Name = "PartNum";
            this.PartNum.ReadOnly = true;
            // 
            // PartDescription
            // 
            this.PartDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartDescription.DataPropertyName = "PartDescription";
            this.PartDescription.HeaderText = "Description";
            this.PartDescription.Name = "PartDescription";
            this.PartDescription.ReadOnly = true;
            this.PartDescription.Width = 85;
            // 
            // TypeCode
            // 
            this.TypeCode.DataPropertyName = "TypeCode";
            this.TypeCode.HeaderText = "Type Code";
            this.TypeCode.Name = "TypeCode";
            this.TypeCode.ReadOnly = true;
            // 
            // ProdCode
            // 
            this.ProdCode.DataPropertyName = "ProdCode";
            this.ProdCode.HeaderText = "Product Code";
            this.ProdCode.Name = "ProdCode";
            this.ProdCode.ReadOnly = true;
            // 
            // SearchWord
            // 
            this.SearchWord.DataPropertyName = "SearchWord";
            this.SearchWord.HeaderText = "Search Word";
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.ReadOnly = true;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "Product Class";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            // 
            // Inactive
            // 
            this.Inactive.DataPropertyName = "Inactive";
            this.Inactive.HeaderText = "Inactive";
            this.Inactive.Name = "Inactive";
            this.Inactive.ReadOnly = true;
            // 
            // PhantomBOM
            // 
            this.PhantomBOM.DataPropertyName = "PhantomBOM";
            this.PhantomBOM.HeaderText = "Phantom BOM";
            this.PhantomBOM.Name = "PhantomBOM";
            this.PhantomBOM.ReadOnly = true;
            // 
            // TrackSerialNum
            // 
            this.TrackSerialNum.DataPropertyName = "TrackSerialNum";
            this.TrackSerialNum.HeaderText = "Serial Number Tracking";
            this.TrackSerialNum.Name = "TrackSerialNum";
            this.TrackSerialNum.ReadOnly = true;
            this.TrackSerialNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackSerialNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QtyBearing
            // 
            this.QtyBearing.DataPropertyName = "QtyBearing";
            this.QtyBearing.HeaderText = "QtyBearing";
            this.QtyBearing.Name = "QtyBearing";
            this.QtyBearing.ReadOnly = true;
            // 
            // SearchPart
            // 
            this.AcceptButton = this.SearchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.HorizMajorContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPart";
            this.Text = "Part Search";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.SearchPart_Load);
            this.tabs.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.basicgroup.ResumeLayout(false);
            this.basicgroup.PerformLayout();
            this.Advanced.ResumeLayout(false);
            this.advSplit.Panel1.ResumeLayout(false);
            this.advSplit.Panel1.PerformLayout();
            this.advSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advSplit)).EndInit();
            this.advSplit.ResumeLayout(false);
            this.advgroup.ResumeLayout(false);
            this.advgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).EndInit();
            this.HorizMajorContainer.Panel1.ResumeLayout(false);
            this.HorizMajorContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizMajorContainer)).EndInit();
            this.HorizMajorContainer.ResumeLayout(false);
            this.VerticalTopContainer.Panel1.ResumeLayout(false);
            this.VerticalTopContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalTopContainer)).EndInit();
            this.VerticalTopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.DataGridView SearchResultGrid;
        private System.Windows.Forms.GroupBox basicgroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.TabPage Advanced;
        private System.Windows.Forms.SplitContainer HorizMajorContainer;
        private System.Windows.Forms.SplitContainer VerticalTopContainer;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button OptionsBtn;
        private System.Windows.Forms.ComboBox sortby_cbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox advgroup;
        private System.Windows.Forms.CheckBox serial_chk;
        private System.Windows.Forms.CheckBox onhold_chk;
        private System.Windows.Forms.CheckBox qtybearing_chk;
        private System.Windows.Forms.CheckBox nonstock_chk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status_cbo;
        private System.Windows.Forms.ComboBox group_cbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type_cbo;
        private System.Windows.Forms.SplitContainer advSplit;
        private System.Windows.Forms.CheckBox AdvSearch;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn OnHold;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn TrackLots;
        private System.Windows.Forms.CheckBox phantom_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inactive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PhantomBOM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrackSerialNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QtyBearing;
    }
}