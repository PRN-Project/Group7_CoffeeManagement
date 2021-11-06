
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignOut.Location = new System.Drawing.Point(695, 387);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(96, 32);
            this.btnSignOut.TabIndex = 37;
            this.btnSignOut.Text = "Close";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRevenue.ForeColor = System.Drawing.Color.Purple;
            this.btnRevenue.Location = new System.Drawing.Point(322, 31);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(137, 42);
            this.btnRevenue.TabIndex = 36;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderList.Location = new System.Drawing.Point(9, 142);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.Size = new System.Drawing.Size(779, 241);
            this.dgvOrderList.TabIndex = 35;
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "frmRevenue";
            this.Text = "frmRevenue";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.DataGridView dgvOrderList;
    }
}