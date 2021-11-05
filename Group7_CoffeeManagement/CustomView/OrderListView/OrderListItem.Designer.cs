
namespace Group7_CoffeeManagement.CustomView.OrderListView
{
    partial class OrderListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFoodName = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.txtDrinkPrice = new System.Windows.Forms.TextBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFoodName
            // 
            this.txtFoodName.AutoSize = true;
            this.txtFoodName.Location = new System.Drawing.Point(7, 8);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(0, 15);
            this.txtFoodName.TabIndex = 0;
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.BackColor = System.Drawing.Color.White;
            this.txtDrinkName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrinkName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDrinkName.Location = new System.Drawing.Point(3, 7);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.ReadOnly = true;
            this.txtDrinkName.Size = new System.Drawing.Size(260, 22);
            this.txtDrinkName.TabIndex = 1;
            // 
            // txtDrinkPrice
            // 
            this.txtDrinkPrice.BackColor = System.Drawing.Color.White;
            this.txtDrinkPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrinkPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDrinkPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDrinkPrice.Location = new System.Drawing.Point(229, 7);
            this.txtDrinkPrice.Name = "txtDrinkPrice";
            this.txtDrinkPrice.ReadOnly = true;
            this.txtDrinkPrice.Size = new System.Drawing.Size(128, 22);
            this.txtDrinkPrice.TabIndex = 2;
            // 
            // nudCount
            // 
            this.nudCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudCount.Location = new System.Drawing.Point(381, 4);
            this.nudCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(43, 29);
            this.nudCount.TabIndex = 3;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.ValueChanged += new System.EventHandler(this.nudCount_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(467, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(118, 22);
            this.txtTotal.TabIndex = 4;
            // 
            // OrderListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.txtDrinkPrice);
            this.Controls.Add(this.txtDrinkName);
            this.Controls.Add(this.txtFoodName);
            this.Name = "OrderListItem";
            this.Size = new System.Drawing.Size(598, 35);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFoodName;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.TextBox txtDrinkPrice;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
