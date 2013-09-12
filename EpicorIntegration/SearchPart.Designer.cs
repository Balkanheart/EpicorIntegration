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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SortBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.Advanced = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.type_cbo = new System.Windows.Forms.ComboBox();
            this.SearchResultGrid = new System.Windows.Forms.DataGridView();
            this.HorizMajorContainer = new System.Windows.Forms.SplitContainer();
            this.VerticalTopContainer = new System.Windows.Forms.SplitContainer();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.group_cbo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Basic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Advanced.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Basic);
            this.tabControl1.Controls.Add(this.Advanced);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 162);
            this.tabControl1.TabIndex = 0;
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.SystemColors.Control;
            this.Basic.Controls.Add(this.groupBox1);
            this.Basic.Location = new System.Drawing.Point(4, 22);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(528, 136);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "Basic";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.SortBy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PartNumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // SortBy
            // 
            this.SortBy.FormattingEnabled = true;
            this.SortBy.Location = new System.Drawing.Point(125, 65);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(167, 21);
            this.SortBy.TabIndex = 6;
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
            this.Advanced.Controls.Add(this.groupBox2);
            this.Advanced.Location = new System.Drawing.Point(4, 22);
            this.Advanced.Name = "Advanced";
            this.Advanced.Padding = new System.Windows.Forms.Padding(3);
            this.Advanced.Size = new System.Drawing.Size(528, 136);
            this.Advanced.TabIndex = 1;
            this.Advanced.Text = "Advanced";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.group_cbo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.type_cbo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Group:";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(334, 38);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(71, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Serialized";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(334, 15);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Inactive";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(228, 84);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "On Hold";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(228, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Phantom BOM";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(228, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Qty Bearing";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(228, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Non-Stock Item";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type Code:";
            // 
            // type_cbo
            // 
            this.type_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cbo.FormattingEnabled = true;
            this.type_cbo.Location = new System.Drawing.Point(74, 13);
            this.type_cbo.Name = "type_cbo";
            this.type_cbo.Size = new System.Drawing.Size(148, 21);
            this.type_cbo.TabIndex = 0;
            // 
            // SearchResultGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchResultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SearchResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultGrid.Location = new System.Drawing.Point(0, 0);
            this.SearchResultGrid.Name = "SearchResultGrid";
            this.SearchResultGrid.Size = new System.Drawing.Size(684, 196);
            this.SearchResultGrid.TabIndex = 0;
            // 
            // HorizMajorContainer
            // 
            this.HorizMajorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.VerticalTopContainer.Location = new System.Drawing.Point(0, 0);
            this.VerticalTopContainer.Name = "VerticalTopContainer";
            // 
            // VerticalTopContainer.Panel1
            // 
            this.VerticalTopContainer.Panel1.Controls.Add(this.tabControl1);
            // 
            // VerticalTopContainer.Panel2
            // 
            this.VerticalTopContainer.Panel2.Controls.Add(this.OptionsBtn);
            this.VerticalTopContainer.Panel2.Controls.Add(this.Clearbtn);
            this.VerticalTopContainer.Panel2.Controls.Add(this.CancelBtn);
            this.VerticalTopContainer.Panel2.Controls.Add(this.SearchBtn);
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
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(12, 41);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(117, 23);
            this.Clearbtn.TabIndex = 3;
            this.Clearbtn.Text = "&Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
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
            // 
            // group_cbo
            // 
            this.group_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cbo.FormattingEnabled = true;
            this.group_cbo.Location = new System.Drawing.Point(74, 52);
            this.group_cbo.Name = "group_cbo";
            this.group_cbo.Size = new System.Drawing.Size(148, 21);
            this.group_cbo.TabIndex = 9;
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
            this.tabControl1.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Advanced.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.DataGridView SearchResultGrid;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ComboBox SortBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type_cbo;
        private System.Windows.Forms.ComboBox group_cbo;
    }
}