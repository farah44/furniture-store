namespace WindowsFormsApp1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label2_EN = new System.Windows.Forms.Label();
            this.textBox1_EName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_SID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1_EID = new System.Windows.Forms.ComboBox();
            this.label1_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3_del = new System.Windows.Forms.Button();
            this.button2_up = new System.Windows.Forms.Button();
            this.button1_ins = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportOneReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTwoOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportThreeModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2_EN
            // 
            this.label2_EN.AutoSize = true;
            this.label2_EN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2_EN.Location = new System.Drawing.Point(7, 64);
            this.label2_EN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_EN.Name = "label2_EN";
            this.label2_EN.Size = new System.Drawing.Size(176, 23);
            this.label2_EN.TabIndex = 2;
            this.label2_EN.Text = "Employee Name";
            // 
            // textBox1_EName
            // 
            this.textBox1_EName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1_EName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_EName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1_EName.Location = new System.Drawing.Point(203, 61);
            this.textBox1_EName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_EName.Name = "textBox1_EName";
            this.textBox1_EName.Size = new System.Drawing.Size(192, 25);
            this.textBox1_EName.TabIndex = 3;
            this.textBox1_EName.TextChanged += new System.EventHandler(this.textBox1_EName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Supervisor ID";
            // 
            // textBox1_SID
            // 
            this.textBox1_SID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1_SID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_SID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1_SID.Location = new System.Drawing.Point(203, 126);
            this.textBox1_SID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_SID.Name = "textBox1_SID";
            this.textBox1_SID.Size = new System.Drawing.Size(192, 25);
            this.textBox1_SID.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 249);
            this.dataGridView1.TabIndex = 21;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Display.FlatAppearance.BorderSize = 0;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Display.Location = new System.Drawing.Point(738, 380);
            this.Display.Margin = new System.Windows.Forms.Padding(4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(112, 33);
            this.Display.TabIndex = 22;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Save.Location = new System.Drawing.Point(738, 421);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 33);
            this.Save.TabIndex = 24;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(5, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 34);
            this.label11.TabIndex = 24;
            this.label11.Text = "Personal Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2_EN);
            this.panel2.Controls.Add(this.textBox1_EName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1_SID);
            this.panel2.Location = new System.Drawing.Point(259, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 172);
            this.panel2.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(254, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(489, 28);
            this.label10.TabIndex = 27;
            this.label10.Text = "Choose Employee ID to show Information";
            // 
            // comboBox1_EID
            // 
            this.comboBox1_EID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1_EID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1_EID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1_EID.FormattingEnabled = true;
            this.comboBox1_EID.Location = new System.Drawing.Point(462, 96);
            this.comboBox1_EID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_EID.Name = "comboBox1_EID";
            this.comboBox1_EID.Size = new System.Drawing.Size(64, 31);
            this.comboBox1_EID.TabIndex = 0;
            this.comboBox1_EID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_EID_SelectedIndexChanged);
            // 
            // label1_ID
            // 
            this.label1_ID.AutoSize = true;
            this.label1_ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1_ID.Location = new System.Drawing.Point(265, 104);
            this.label1_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_ID.Name = "label1_ID";
            this.label1_ID.Size = new System.Drawing.Size(135, 23);
            this.label1_ID.TabIndex = 1;
            this.label1_ID.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(265, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Click Display to show Employees Data and Save to save updated Info";
            // 
            // button3_del
            // 
            this.button3_del.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3_del.FlatAppearance.BorderSize = 0;
            this.button3_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3_del.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3_del.Location = new System.Drawing.Point(93, 221);
            this.button3_del.Margin = new System.Windows.Forms.Padding(4);
            this.button3_del.Name = "button3_del";
            this.button3_del.Size = new System.Drawing.Size(96, 43);
            this.button3_del.TabIndex = 11;
            this.button3_del.Text = "Delete";
            this.button3_del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3_del.UseVisualStyleBackColor = false;
            this.button3_del.Click += new System.EventHandler(this.button3_del_Click);
            // 
            // button2_up
            // 
            this.button2_up.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2_up.FlatAppearance.BorderSize = 0;
            this.button2_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_up.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2_up.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2_up.Location = new System.Drawing.Point(92, 170);
            this.button2_up.Margin = new System.Windows.Forms.Padding(4);
            this.button2_up.Name = "button2_up";
            this.button2_up.Size = new System.Drawing.Size(96, 43);
            this.button2_up.TabIndex = 10;
            this.button2_up.Text = "Update";
            this.button2_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2_up.UseVisualStyleBackColor = false;
            this.button2_up.Click += new System.EventHandler(this.button2_up_Click);
            // 
            // button1_ins
            // 
            this.button1_ins.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1_ins.FlatAppearance.BorderSize = 0;
            this.button1_ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_ins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1_ins.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1_ins.Location = new System.Drawing.Point(92, 119);
            this.button1_ins.Margin = new System.Windows.Forms.Padding(4);
            this.button1_ins.Name = "button1_ins";
            this.button1_ins.Size = new System.Drawing.Size(96, 43);
            this.button1_ins.TabIndex = 9;
            this.button1_ins.Text = "Insert";
            this.button1_ins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_ins.UseVisualStyleBackColor = false;
            this.button1_ins.Click += new System.EventHandler(this.button1_ins_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 38);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.productToolStripMenuItem});
            this.tablesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click_2);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.orderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click_1);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click_1);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click_1);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportOneReviewsToolStripMenuItem,
            this.reportTwoOrdersToolStripMenuItem,
            this.reportThreeModelToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // reportOneReviewsToolStripMenuItem
            // 
            this.reportOneReviewsToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.reportOneReviewsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportOneReviewsToolStripMenuItem.Name = "reportOneReviewsToolStripMenuItem";
            this.reportOneReviewsToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.reportOneReviewsToolStripMenuItem.Text = "Report One(Reviews)";
            this.reportOneReviewsToolStripMenuItem.Click += new System.EventHandler(this.reportOneReviewsToolStripMenuItem_Click);
            // 
            // reportTwoOrdersToolStripMenuItem
            // 
            this.reportTwoOrdersToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.reportTwoOrdersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportTwoOrdersToolStripMenuItem.Name = "reportTwoOrdersToolStripMenuItem";
            this.reportTwoOrdersToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.reportTwoOrdersToolStripMenuItem.Text = "Report Two(Orders)";
            this.reportTwoOrdersToolStripMenuItem.Click += new System.EventHandler(this.reportTwoOrdersToolStripMenuItem_Click);
            // 
            // reportThreeModelToolStripMenuItem
            // 
            this.reportThreeModelToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.reportThreeModelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportThreeModelToolStripMenuItem.Name = "reportThreeModelToolStripMenuItem";
            this.reportThreeModelToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.reportThreeModelToolStripMenuItem.Text = "Report Three(Model)";
            this.reportThreeModelToolStripMenuItem.Click += new System.EventHandler(this.reportThreeModelToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 629);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 559);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 493);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3_del);
            this.Controls.Add(this.button2_up);
            this.Controls.Add(this.button1_ins);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1_ID);
            this.Controls.Add(this.comboBox1_EID);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2_EN;
        private System.Windows.Forms.TextBox textBox1_EName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_SID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1_EID;
        private System.Windows.Forms.Label label1_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3_del;
        private System.Windows.Forms.Button button2_up;
        private System.Windows.Forms.Button button1_ins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportOneReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportTwoOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportThreeModelToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}