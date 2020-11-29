namespace WindowsFormsApp1
{
    partial class R2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R2));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Display = new System.Windows.Forms.Button();
            this.comboBox1_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(92, 118);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1132, 544);
            this.crystalReportViewer1.TabIndex = 73;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Display.FlatAppearance.BorderSize = 0;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Display.Location = new System.Drawing.Point(562, 53);
            this.Display.Margin = new System.Windows.Forms.Padding(4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(211, 33);
            this.Display.TabIndex = 72;
            this.Display.Text = "Orders Report";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // comboBox1_ID
            // 
            this.comboBox1_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1_ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1_ID.FormattingEnabled = true;
            this.comboBox1_ID.Location = new System.Drawing.Point(360, 55);
            this.comboBox1_ID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_ID.Name = "comboBox1_ID";
            this.comboBox1_ID.Size = new System.Drawing.Size(158, 31);
            this.comboBox1_ID.TabIndex = 70;
            this.comboBox1_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_ID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.menuStrip1.TabIndex = 74;
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
            this.panel1.TabIndex = 75;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 559);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 493);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // R2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.comboBox1_ID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "R2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R2";
            this.Load += new System.EventHandler(this.R2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.ComboBox comboBox1_ID;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}