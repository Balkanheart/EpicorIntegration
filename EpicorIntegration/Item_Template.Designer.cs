﻿namespace EpicorIntegration
{
    partial class Item_Template
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Template));
            this.label1 = new System.Windows.Forms.Label();
            this.Partnumber_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type_cbo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NetWeight = new System.Windows.Forms.NumericUpDown();
            this.NetVolume = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.group_cbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.class_cbo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uomclass_cbo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uom_cbo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.whse_cbo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.plant_cbo = new System.Windows.Forms.ComboBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.uomweight_cbo = new System.Windows.Forms.ComboBox();
            this.uomvol_cbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.engDataDataSet = new EpicorIntegration.ENGDataDataSet();
            this.BS_EngDataDataSet = new System.Windows.Forms.BindingSource(this.components);
            this.itemTemplateTableAdapter = new EpicorIntegration.ENGDataDataSetTableAdapters.ItemTemplateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NetWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_EngDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Number:";
            // 
            // Partnumber_txt
            // 
            this.Partnumber_txt.Location = new System.Drawing.Point(9, 32);
            this.Partnumber_txt.Name = "Partnumber_txt";
            this.Partnumber_txt.Size = new System.Drawing.Size(333, 20);
            this.Partnumber_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // Description_txt
            // 
            this.Description_txt.Location = new System.Drawing.Point(9, 71);
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(333, 20);
            this.Description_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type:";
            // 
            // type_cbo
            // 
            this.type_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cbo.FormattingEnabled = true;
            this.type_cbo.Location = new System.Drawing.Point(9, 110);
            this.type_cbo.Name = "type_cbo";
            this.type_cbo.Size = new System.Drawing.Size(157, 21);
            this.type_cbo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit Net Weight";
            // 
            // NetWeight
            // 
            this.NetWeight.DecimalPlaces = 2;
            this.NetWeight.Location = new System.Drawing.Point(9, 150);
            this.NetWeight.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.Size = new System.Drawing.Size(102, 20);
            this.NetWeight.TabIndex = 13;
            this.NetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NetVolume
            // 
            this.NetVolume.DecimalPlaces = 2;
            this.NetVolume.Location = new System.Drawing.Point(9, 189);
            this.NetVolume.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.NetVolume.Name = "NetVolume";
            this.NetVolume.Size = new System.Drawing.Size(102, 20);
            this.NetVolume.TabIndex = 15;
            this.NetVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unit Net Volume";
            // 
            // group_cbo
            // 
            this.group_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cbo.FormattingEnabled = true;
            this.group_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.group_cbo.Location = new System.Drawing.Point(9, 268);
            this.group_cbo.Name = "group_cbo";
            this.group_cbo.Size = new System.Drawing.Size(210, 21);
            this.group_cbo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Group:";
            // 
            // class_cbo
            // 
            this.class_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_cbo.FormattingEnabled = true;
            this.class_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.class_cbo.Location = new System.Drawing.Point(9, 308);
            this.class_cbo.Name = "class_cbo";
            this.class_cbo.Size = new System.Drawing.Size(210, 21);
            this.class_cbo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Class:";
            // 
            // uomclass_cbo
            // 
            this.uomclass_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uomclass_cbo.FormattingEnabled = true;
            this.uomclass_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.uomclass_cbo.Location = new System.Drawing.Point(172, 110);
            this.uomclass_cbo.Name = "uomclass_cbo";
            this.uomclass_cbo.Size = new System.Drawing.Size(157, 21);
            this.uomclass_cbo.TabIndex = 21;
            this.uomclass_cbo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "UOM Class:";
            this.label8.Visible = false;
            // 
            // uom_cbo
            // 
            this.uom_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uom_cbo.FormattingEnabled = true;
            this.uom_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.uom_cbo.Location = new System.Drawing.Point(9, 228);
            this.uom_cbo.Name = "uom_cbo";
            this.uom_cbo.Size = new System.Drawing.Size(180, 21);
            this.uom_cbo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Inventory UOM:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Warehouse:";
            // 
            // whse_cbo
            // 
            this.whse_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whse_cbo.FormattingEnabled = true;
            this.whse_cbo.Location = new System.Drawing.Point(8, 72);
            this.whse_cbo.Name = "whse_cbo";
            this.whse_cbo.Size = new System.Drawing.Size(321, 21);
            this.whse_cbo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Plant:";
            // 
            // plant_cbo
            // 
            this.plant_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plant_cbo.FormattingEnabled = true;
            this.plant_cbo.Location = new System.Drawing.Point(8, 32);
            this.plant_cbo.Name = "plant_cbo";
            this.plant_cbo.Size = new System.Drawing.Size(321, 21);
            this.plant_cbo.TabIndex = 27;
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(290, 476);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 29;
            this.cancelbtn.Text = "&Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(209, 476);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 30;
            this.savebtn.Text = "&Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // uomweight_cbo
            // 
            this.uomweight_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uomweight_cbo.FormattingEnabled = true;
            this.uomweight_cbo.Location = new System.Drawing.Point(117, 149);
            this.uomweight_cbo.Name = "uomweight_cbo";
            this.uomweight_cbo.Size = new System.Drawing.Size(72, 21);
            this.uomweight_cbo.TabIndex = 31;
            // 
            // uomvol_cbo
            // 
            this.uomvol_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uomvol_cbo.FormattingEnabled = true;
            this.uomvol_cbo.Location = new System.Drawing.Point(117, 188);
            this.uomvol_cbo.Name = "uomvol_cbo";
            this.uomvol_cbo.Size = new System.Drawing.Size(72, 21);
            this.uomvol_cbo.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uomvol_cbo);
            this.groupBox1.Controls.Add(this.Partnumber_txt);
            this.groupBox1.Controls.Add(this.uomweight_cbo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Description_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.type_cbo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NetWeight);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NetVolume);
            this.groupBox1.Controls.Add(this.uom_cbo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uomclass_cbo);
            this.groupBox1.Controls.Add(this.group_cbo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.class_cbo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 344);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.whse_cbo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.plant_cbo);
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 108);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plants";
            // 
            // engDataDataSet
            // 
            this.engDataDataSet.DataSetName = "ENGDataDataSet";
            this.engDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_EngDataDataSet
            // 
            this.BS_EngDataDataSet.DataMember = "ItemTemplate";
            this.BS_EngDataDataSet.DataSource = this.engDataDataSet;
            // 
            // itemTemplateTableAdapter
            // 
            this.itemTemplateTableAdapter.ClearBeforeFill = true;
            // 
            // Item_Template
            // 
            this.AcceptButton = this.savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(378, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.cancelbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item_Template";
            this.Text = "Epicor Item Injection";
            this.Load += new System.EventHandler(this.Item_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NetWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_EngDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Partnumber_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type_cbo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NetWeight;
        private System.Windows.Forms.NumericUpDown NetVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox group_cbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox class_cbo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox uomclass_cbo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox uom_cbo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox whse_cbo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox plant_cbo;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox uomweight_cbo;
        private System.Windows.Forms.ComboBox uomvol_cbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ENGDataDataSet engDataDataSet;
        private System.Windows.Forms.BindingSource BS_EngDataDataSet;
        private ENGDataDataSetTableAdapters.ItemTemplateTableAdapter itemTemplateTableAdapter;
    }
}

