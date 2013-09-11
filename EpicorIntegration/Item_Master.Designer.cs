namespace EpicorIntegration
{
    partial class Item_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Master));
            this.label1 = new System.Windows.Forms.Label();
            this.Partnumber_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type_cbo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Number:";
            // 
            // Partnumber_txt
            // 
            this.Partnumber_txt.Location = new System.Drawing.Point(15, 25);
            this.Partnumber_txt.Name = "Partnumber_txt";
            this.Partnumber_txt.Size = new System.Drawing.Size(333, 20);
            this.Partnumber_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type:";
            // 
            // type_cbo
            // 
            this.type_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cbo.FormattingEnabled = true;
            this.type_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.type_cbo.Location = new System.Drawing.Point(15, 103);
            this.type_cbo.Name = "type_cbo";
            this.type_cbo.Size = new System.Drawing.Size(157, 21);
            this.type_cbo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit Net Weight";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(15, 143);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(123, 143);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 127);
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
            this.group_cbo.Location = new System.Drawing.Point(15, 182);
            this.group_cbo.Name = "group_cbo";
            this.group_cbo.Size = new System.Drawing.Size(210, 21);
            this.group_cbo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
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
            this.class_cbo.Location = new System.Drawing.Point(15, 222);
            this.class_cbo.Name = "class_cbo";
            this.class_cbo.Size = new System.Drawing.Size(210, 21);
            this.class_cbo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
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
            this.uomclass_cbo.Location = new System.Drawing.Point(178, 103);
            this.uomclass_cbo.Name = "uomclass_cbo";
            this.uomclass_cbo.Size = new System.Drawing.Size(157, 21);
            this.uomclass_cbo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "UOM Class:";
            // 
            // uom_cbo
            // 
            this.uom_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uom_cbo.FormattingEnabled = true;
            this.uom_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.uom_cbo.Location = new System.Drawing.Point(15, 262);
            this.uom_cbo.Name = "uom_cbo";
            this.uom_cbo.Size = new System.Drawing.Size(132, 21);
            this.uom_cbo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Primary UOM:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Warehouse:";
            // 
            // whse_cbo
            // 
            this.whse_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whse_cbo.FormattingEnabled = true;
            this.whse_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.whse_cbo.Location = new System.Drawing.Point(15, 342);
            this.whse_cbo.Name = "whse_cbo";
            this.whse_cbo.Size = new System.Drawing.Size(150, 21);
            this.whse_cbo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Plant:";
            // 
            // plant_cbo
            // 
            this.plant_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plant_cbo.FormattingEnabled = true;
            this.plant_cbo.Items.AddRange(new object[] {
            "Purchased",
            "Manufacturer",
            "Sales Kit"});
            this.plant_cbo.Location = new System.Drawing.Point(15, 302);
            this.plant_cbo.Name = "plant_cbo";
            this.plant_cbo.Size = new System.Drawing.Size(150, 21);
            this.plant_cbo.TabIndex = 27;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(283, 416);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 29;
            this.cancelbtn.Text = "&Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(202, 416);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 30;
            this.savebtn.Text = "&Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // Item_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 451);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.plant_cbo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.whse_cbo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uom_cbo);
            this.Controls.Add(this.uomclass_cbo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.class_cbo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.group_cbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type_cbo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Partnumber_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item_Master";
            this.Text = "EPDM to Epicor";
            this.Load += new System.EventHandler(this.Item_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Partnumber_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type_cbo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
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
    }
}

