
namespace Group7_CoffeeManagement.Revenue
{
    partial class frmRevenue
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFilterType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelYear = new System.Windows.Forms.Panel();
            this.nudYear_ofYear = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.panelDateRange = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate_ofDate = new System.Windows.Forms.DateTimePicker();
            this.panelDate = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMonth_ofMonth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudYear_ofMonth = new System.Windows.Forms.NumericUpDown();
            this.panelByMonth = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnOutputRevenue = new System.Windows.Forms.Button();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear_ofYear)).BeginInit();
            this.panelDateRange.SuspendLayout();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth_ofMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear_ofMonth)).BeginInit();
            this.panelByMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doanh thu";
            // 
            // cbbFilterType
            // 
            this.cbbFilterType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFilterType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbFilterType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbFilterType.FormattingEnabled = true;
            this.cbbFilterType.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo năm",
            "Theo khoảng thời gian"});
            this.cbbFilterType.Location = new System.Drawing.Point(627, 103);
            this.cbbFilterType.Name = "cbbFilterType";
            this.cbbFilterType.Size = new System.Drawing.Size(278, 36);
            this.cbbFilterType.TabIndex = 29;
            this.cbbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbbFilterType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(853, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Bộ lọc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelYear
            // 
            this.panelYear.AutoSize = true;
            this.panelYear.Controls.Add(this.nudYear_ofYear);
            this.panelYear.Controls.Add(this.label12);
            this.panelYear.Location = new System.Drawing.Point(12, 76);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(136, 68);
            this.panelYear.TabIndex = 34;
            // 
            // nudYear_ofYear
            // 
            this.nudYear_ofYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudYear_ofYear.Location = new System.Drawing.Point(3, 31);
            this.nudYear_ofYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudYear_ofYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear_ofYear.Name = "nudYear_ofYear";
            this.nudYear_ofYear.Size = new System.Drawing.Size(130, 34);
            this.nudYear_ofYear.TabIndex = 32;
            this.nudYear_ofYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Năm";
            // 
            // panelDateRange
            // 
            this.panelDateRange.AutoSize = true;
            this.panelDateRange.Controls.Add(this.dtpEndDate);
            this.panelDateRange.Controls.Add(this.label8);
            this.panelDateRange.Controls.Add(this.dtpStartDate);
            this.panelDateRange.Controls.Add(this.label7);
            this.panelDateRange.Location = new System.Drawing.Point(12, 76);
            this.panelDateRange.Name = "panelDateRange";
            this.panelDateRange.Size = new System.Drawing.Size(356, 67);
            this.panelDateRange.TabIndex = 35;
            this.panelDateRange.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(188, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(165, 34);
            this.dtpEndDate.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(188, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ngày kết thúc";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(2, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(168, 34);
            this.dtpStartDate.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Chọn ngày";
            // 
            // dtpDate_ofDate
            // 
            this.dtpDate_ofDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate_ofDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate_ofDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate_ofDate.Location = new System.Drawing.Point(3, 30);
            this.dtpDate_ofDate.Name = "dtpDate_ofDate";
            this.dtpDate_ofDate.Size = new System.Drawing.Size(353, 34);
            this.dtpDate_ofDate.TabIndex = 16;
            // 
            // panelDate
            // 
            this.panelDate.AutoSize = true;
            this.panelDate.Controls.Add(this.dtpDate_ofDate);
            this.panelDate.Controls.Add(this.label5);
            this.panelDate.Location = new System.Drawing.Point(12, 76);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(359, 67);
            this.panelDate.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tháng";
            // 
            // nudMonth_ofMonth
            // 
            this.nudMonth_ofMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMonth_ofMonth.Location = new System.Drawing.Point(3, 31);
            this.nudMonth_ofMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth_ofMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth_ofMonth.Name = "nudMonth_ofMonth";
            this.nudMonth_ofMonth.Size = new System.Drawing.Size(130, 34);
            this.nudMonth_ofMonth.TabIndex = 30;
            this.nudMonth_ofMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(142, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Năm";
            // 
            // nudYear_ofMonth
            // 
            this.nudYear_ofMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudYear_ofMonth.Location = new System.Drawing.Point(143, 31);
            this.nudYear_ofMonth.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudYear_ofMonth.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear_ofMonth.Name = "nudYear_ofMonth";
            this.nudYear_ofMonth.Size = new System.Drawing.Size(130, 34);
            this.nudYear_ofMonth.TabIndex = 32;
            this.nudYear_ofMonth.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // panelByMonth
            // 
            this.panelByMonth.AutoSize = true;
            this.panelByMonth.Controls.Add(this.nudYear_ofMonth);
            this.panelByMonth.Controls.Add(this.label3);
            this.panelByMonth.Controls.Add(this.nudMonth_ofMonth);
            this.panelByMonth.Controls.Add(this.label2);
            this.panelByMonth.Location = new System.Drawing.Point(12, 76);
            this.panelByMonth.Name = "panelByMonth";
            this.panelByMonth.Size = new System.Drawing.Size(276, 68);
            this.panelByMonth.TabIndex = 37;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvOrderList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 164);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.Size = new System.Drawing.Size(895, 443);
            this.dgvOrderList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Location = new System.Drawing.Point(12, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 56);
            this.panel1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng:";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(80, 14);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(161, 28);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "300,250,300 vnđ";
            // 
            // btnOutputRevenue
            // 
            this.btnOutputRevenue.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOutputRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOutputRevenue.ForeColor = System.Drawing.Color.White;
            this.btnOutputRevenue.Location = new System.Drawing.Point(390, 105);
            this.btnOutputRevenue.Name = "btnOutputRevenue";
            this.btnOutputRevenue.Size = new System.Drawing.Size(145, 38);
            this.btnOutputRevenue.TabIndex = 39;
            this.btnOutputRevenue.Text = "Xuất doanh thu";
            this.btnOutputRevenue.UseVisualStyleBackColor = false;
            this.btnOutputRevenue.Click += new System.EventHandler(this.btnOutputRevenue_Click);
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 678);
            this.Controls.Add(this.btnOutputRevenue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelByMonth);
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.panelDateRange);
            this.Controls.Add(this.panelYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbFilterType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "frmRevenue";
            this.Text = "frmRevenue";
            this.panelYear.ResumeLayout(false);
            this.panelYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear_ofYear)).EndInit();
            this.panelDateRange.ResumeLayout(false);
            this.panelDateRange.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth_ofMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear_ofMonth)).EndInit();
            this.panelByMonth.ResumeLayout(false);
            this.panelByMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFilterType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown nudYear_ofYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate_ofDate;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMonth_ofMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudYear_ofMonth;
        private System.Windows.Forms.Panel panelByMonth;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnOutputRevenue;
    }
}