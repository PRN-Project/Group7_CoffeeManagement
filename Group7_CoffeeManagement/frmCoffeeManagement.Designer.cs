
namespace Group7_CoffeeManagement
{
    partial class frmCoffeeManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.Label();
            this.btnRemoveDrinkOut = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbbDrinkType = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.panelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.edtFoodName = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelOrder);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTableName);
            this.panel2.Location = new System.Drawing.Point(369, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 584);
            this.panel2.TabIndex = 2;
            // 
            // panelOrder
            // 
            this.panelOrder.AutoScroll = true;
            this.panelOrder.BackColor = System.Drawing.SystemColors.Window;
            this.panelOrder.Location = new System.Drawing.Point(1, 72);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(1);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(611, 511);
            this.panelOrder.TabIndex = 28;
            this.panelOrder.WrapContents = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(464, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tổng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(375, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên món";
            // 
            // label1
            // 
            this.txtTableName.AutoSize = true;
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTableName.Location = new System.Drawing.Point(-3, 7);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(68, 25);
            this.txtTableName.TabIndex = 7;
            this.txtTableName.Text = "Bàn 15";
            // 
            // btnRemoveDrinkOut
            // 
            this.btnRemoveDrinkOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveDrinkOut.Location = new System.Drawing.Point(832, 604);
            this.btnRemoveDrinkOut.Name = "btnRemoveDrinkOut";
            this.btnRemoveDrinkOut.Size = new System.Drawing.Size(126, 51);
            this.btnRemoveDrinkOut.TabIndex = 25;
            this.btnRemoveDrinkOut.Text = "Xóa";
            this.btnRemoveDrinkOut.UseVisualStyleBackColor = true;
            this.btnRemoveDrinkOut.Click += new System.EventHandler(this.btnRemoveDrinkOut_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrder.Location = new System.Drawing.Point(1096, 604);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(123, 51);
            this.btnUpdateOrder.TabIndex = 20;
            this.btnUpdateOrder.Text = "Cập nhật";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1225, 602);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 51);
            this.button5.TabIndex = 22;
            this.button5.Text = "Chuyển bàn";
            this.button5.UseVisualStyleBackColor = true; 
            // 
            // cbbDrinkType
            // 
            this.cbbDrinkType.FormattingEnabled = true;
            this.cbbDrinkType.Location = new System.Drawing.Point(988, 13);
            this.cbbDrinkType.Name = "cbbDrinkType";
            this.cbbDrinkType.Size = new System.Drawing.Size(354, 32);
            this.cbbDrinkType.TabIndex = 1;
            this.cbbDrinkType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbDrinkType.SelectedIndexChanged += new System.EventHandler(this.cbbDrinkType_SelectedIndexChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(80, 15);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(90, 21);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.Text = "50.000 vnd";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(-1, 14);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(80, 21);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Tổng tiền";
            // 
            // panelTables
            // 
            this.panelTables.AutoScroll = true;
            this.panelTables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTables.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelTables.Location = new System.Drawing.Point(9, 10);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(351, 646);
            this.panelTables.TabIndex = 3;
            this.panelTables.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Location = new System.Drawing.Point(368, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 52);
            this.panel1.TabIndex = 9;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(964, 603);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(126, 51);
            this.btnCheckOut.TabIndex = 24;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // edtFoodName
            // 
            this.edtFoodName.Location = new System.Drawing.Point(988, 50);
            this.edtFoodName.Name = "edtFoodName";
            this.edtFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtFoodName.Size = new System.Drawing.Size(353, 32);
            this.edtFoodName.TabIndex = 25;
            this.edtFoodName.TextChanged += EdtFoodName_TextChanged;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(988, 85);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(353, 512);
            this.panelMenu.TabIndex = 26;
            // 
            // frmCoffeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 668);
            this.Controls.Add(this.btnRemoveDrinkOut);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.edtFoodName);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbbDrinkType);
            this.Name = "frmCoffeeManagement";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.ComboBox cbbDrinkType;
        private System.Windows.Forms.FlowLayoutPanel tablePanel;
        private System.Windows.Forms.FlowLayoutPanel panelTables;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTableName;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelOrder;
        private System.Windows.Forms.Button btnRemoveDrinkOut;
        private System.Windows.Forms.TextBox edtFoodName;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
    }
}