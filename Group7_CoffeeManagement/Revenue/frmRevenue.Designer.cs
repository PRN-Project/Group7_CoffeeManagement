
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate_ofDate = new System.Windows.Forms.DateTimePicker();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnOutputRevenue = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.panelDate.SuspendLayout();
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
            this.panelDate.Location = new System.Drawing.Point(12, 77);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(359, 67);
            this.panelDate.TabIndex = 36;
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
            this.txtTotal.Size = new System.Drawing.Size(60, 28);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "______";
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
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.Location = new System.Drawing.Point(762, 106);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(145, 38);
            this.btnViewBill.TabIndex = 40;
            this.btnViewBill.Text = "Xem hóa đơn";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 678);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnOutputRevenue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "frmRevenue";
            this.Text = "frmRevenue";
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate_ofDate;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnOutputRevenue;
        private System.Windows.Forms.Button btnViewBill;
    }
}