namespace EpicorIntegration
{
    partial class Bill_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Master));
            this.MajorHorizSplit = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.parentrev_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gid_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copy_btn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.parentdesc_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parent_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qty_num = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partnum_txt = new System.Windows.Forms.TextBox();
            this.ops_cbo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.findpart_btn = new System.Windows.Forms.Button();
            this.mtlseq_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MajorHorizSplit)).BeginInit();
            this.MajorHorizSplit.Panel1.SuspendLayout();
            this.MajorHorizSplit.Panel2.SuspendLayout();
            this.MajorHorizSplit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGrid)).BeginInit();
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
            this.MajorHorizSplit.Panel1.Controls.Add(this.label8);
            this.MajorHorizSplit.Panel1.Controls.Add(this.parentrev_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label7);
            this.MajorHorizSplit.Panel1.Controls.Add(this.gid_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.groupBox2);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label2);
            this.MajorHorizSplit.Panel1.Controls.Add(this.parentdesc_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.label1);
            this.MajorHorizSplit.Panel1.Controls.Add(this.parent_txt);
            this.MajorHorizSplit.Panel1.Controls.Add(this.groupBox1);
            // 
            // MajorHorizSplit.Panel2
            // 
            this.MajorHorizSplit.Panel2.Controls.Add(this.BillDataGrid);
            this.MajorHorizSplit.Size = new System.Drawing.Size(491, 466);
            this.MajorHorizSplit.SplitterDistance = 262;
            this.MajorHorizSplit.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Parent Revision:";
            // 
            // parentrev_txt
            // 
            this.parentrev_txt.Location = new System.Drawing.Point(158, 64);
            this.parentrev_txt.Name = "parentrev_txt";
            this.parentrev_txt.Size = new System.Drawing.Size(82, 20);
            this.parentrev_txt.TabIndex = 10;
            this.parentrev_txt.Text = "D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Group ID:";
            // 
            // gid_txt
            // 
            this.gid_txt.Location = new System.Drawing.Point(15, 64);
            this.gid_txt.Name = "gid_txt";
            this.gid_txt.Size = new System.Drawing.Size(82, 20);
            this.gid_txt.TabIndex = 8;
            this.gid_txt.Text = "TW";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copy_btn);
            this.groupBox2.Controls.Add(this.newbtn);
            this.groupBox2.Controls.Add(this.removebtn);
            this.groupBox2.Controls.Add(this.cancelbtn);
            this.groupBox2.Controls.Add(this.savebtn);
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 239);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(6, 103);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(75, 23);
            this.copy_btn.TabIndex = 14;
            this.copy_btn.Text = "&Copy From...";
            this.copy_btn.UseVisualStyleBackColor = true;
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(6, 16);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "&New";
            this.newbtn.UseVisualStyleBackColor = true;
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(6, 74);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(75, 23);
            this.removebtn.TabIndex = 1;
            this.removebtn.Text = "&Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(6, 210);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // parentdesc_txt
            // 
            this.parentdesc_txt.Location = new System.Drawing.Point(158, 25);
            this.parentdesc_txt.Name = "parentdesc_txt";
            this.parentdesc_txt.Size = new System.Drawing.Size(226, 20);
            this.parentdesc_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parent Part:";
            // 
            // parent_txt
            // 
            this.parent_txt.Location = new System.Drawing.Point(15, 25);
            this.parent_txt.Name = "parent_txt";
            this.parent_txt.Size = new System.Drawing.Size(137, 20);
            this.parent_txt.TabIndex = 1;
            this.parent_txt.Text = "Test12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qty_num);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.desc_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.partnum_txt);
            this.groupBox1.Controls.Add(this.ops_cbo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.findpart_btn);
            this.groupBox1.Controls.Add(this.mtlseq_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // qty_num
            // 
            this.qty_num.DecimalPlaces = 2;
            this.qty_num.Location = new System.Drawing.Point(75, 124);
            this.qty_num.Name = "qty_num";
            this.qty_num.Size = new System.Drawing.Size(62, 20);
            this.qty_num.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Qty.";
            // 
            // desc_txt
            // 
            this.desc_txt.BackColor = System.Drawing.Color.White;
            this.desc_txt.Location = new System.Drawing.Point(75, 71);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.ReadOnly = true;
            this.desc_txt.Size = new System.Drawing.Size(211, 20);
            this.desc_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // partnum_txt
            // 
            this.partnum_txt.Location = new System.Drawing.Point(75, 45);
            this.partnum_txt.Name = "partnum_txt";
            this.partnum_txt.Size = new System.Drawing.Size(211, 20);
            this.partnum_txt.TabIndex = 5;
            // 
            // ops_cbo
            // 
            this.ops_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ops_cbo.FormattingEnabled = true;
            this.ops_cbo.Location = new System.Drawing.Point(75, 97);
            this.ops_cbo.Name = "ops_cbo";
            this.ops_cbo.Size = new System.Drawing.Size(211, 21);
            this.ops_cbo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operation:";
            // 
            // findpart_btn
            // 
            this.findpart_btn.Location = new System.Drawing.Point(7, 43);
            this.findpart_btn.Name = "findpart_btn";
            this.findpart_btn.Size = new System.Drawing.Size(62, 23);
            this.findpart_btn.TabIndex = 2;
            this.findpart_btn.Text = "Part";
            this.findpart_btn.UseVisualStyleBackColor = true;
            this.findpart_btn.Click += new System.EventHandler(this.findpart_btn_Click);
            // 
            // mtlseq_txt
            // 
            this.mtlseq_txt.Location = new System.Drawing.Point(75, 19);
            this.mtlseq_txt.Name = "mtlseq_txt";
            this.mtlseq_txt.Size = new System.Drawing.Size(62, 20);
            this.mtlseq_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mtl Seq:";
            // 
            // BillDataGrid
            // 
            this.BillDataGrid.AllowUserToAddRows = false;
            this.BillDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BillDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.BillDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BillDataGrid.Location = new System.Drawing.Point(0, 0);
            this.BillDataGrid.MultiSelect = false;
            this.BillDataGrid.Name = "BillDataGrid";
            this.BillDataGrid.ReadOnly = true;
            this.BillDataGrid.RowHeadersVisible = false;
            this.BillDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDataGrid.ShowCellErrors = false;
            this.BillDataGrid.ShowCellToolTips = false;
            this.BillDataGrid.ShowEditingIcon = false;
            this.BillDataGrid.ShowRowErrors = false;
            this.BillDataGrid.Size = new System.Drawing.Size(491, 200);
            this.BillDataGrid.TabIndex = 1;
            // 
            // Bill_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(491, 466);
            this.Controls.Add(this.MajorHorizSplit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(507, 504);
            this.Name = "Bill_Master";
            this.Text = "Add Materials To...";
            this.Load += new System.EventHandler(this.Bill_Master_Load);
            this.MajorHorizSplit.Panel1.ResumeLayout(false);
            this.MajorHorizSplit.Panel1.PerformLayout();
            this.MajorHorizSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MajorHorizSplit)).EndInit();
            this.MajorHorizSplit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MajorHorizSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parentdesc_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parent_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown qty_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox partnum_txt;
        private System.Windows.Forms.ComboBox ops_cbo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findpart_btn;
        private System.Windows.Forms.TextBox mtlseq_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView BillDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox parentrev_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gid_txt;

    }
}