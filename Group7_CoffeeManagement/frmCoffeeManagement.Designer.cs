
using System.Drawing;

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
            this.txtEmpty = new System.Windows.Forms.Label();
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
            this.mnstrip = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckOutDisabled = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtEmpty);
            this.panel2.Controls.Add(this.panelOrder);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTableName);
            this.panel2.Location = new System.Drawing.Point(369, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 590);
            this.panel2.TabIndex = 2;
            // 
            // txtEmpty
            // 
            this.txtEmpty.AutoSize = true;
            this.txtEmpty.BackColor = System.Drawing.Color.White;
            this.txtEmpty.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmpty.Location = new System.Drawing.Point(264, 333);
            this.txtEmpty.Name = "txtEmpty";
            this.txtEmpty.Size = new System.Drawing.Size(88, 37);
            this.txtEmpty.TabIndex = 1;
            this.txtEmpty.Text = "Trống";
            // 
            // panelOrder
            // 
            this.panelOrder.AutoScroll = true;
            this.panelOrder.BackColor = System.Drawing.SystemColors.Window;
            this.panelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrder.Location = new System.Drawing.Point(-1, 79);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(1);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(613, 511);
            this.panelOrder.TabIndex = 28;
            this.panelOrder.WrapContents = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(544, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tổng ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(375, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(235, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá tiền";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên món";
            // 
            // txtTableName
            // 
            this.txtTableName.AutoSize = true;
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.txtTableName.Location = new System.Drawing.Point(2, 1);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(135, 37);
            this.txtTableName.TabIndex = 7;
            this.txtTableName.Text = "Chọn bàn";
            // 
            // btnRemoveDrinkOut
            // 
            this.btnRemoveDrinkOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemoveDrinkOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveDrinkOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveDrinkOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveDrinkOut.Location = new System.Drawing.Point(1110, 633);
            this.btnRemoveDrinkOut.Name = "btnRemoveDrinkOut";
            this.btnRemoveDrinkOut.Size = new System.Drawing.Size(109, 52);
            this.btnRemoveDrinkOut.TabIndex = 25;
            this.btnRemoveDrinkOut.Text = "Xóa món";
            this.btnRemoveDrinkOut.UseVisualStyleBackColor = false;
            this.btnRemoveDrinkOut.Click += new System.EventHandler(this.btnRemoveDrinkOut_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOrder.Location = new System.Drawing.Point(988, 633);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(116, 52);
            this.btnUpdateOrder.TabIndex = 20;
            this.btnUpdateOrder.Text = "Tạo bàn";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(1225, 633);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 52);
            this.button5.TabIndex = 22;
            this.button5.Text = "Chuyển bàn";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // cbbDrinkType
            // 
            this.cbbDrinkType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbDrinkType.FormattingEnabled = true;
            this.cbbDrinkType.Location = new System.Drawing.Point(988, 38);
            this.cbbDrinkType.Name = "cbbDrinkType";
            this.cbbDrinkType.Size = new System.Drawing.Size(354, 29);
            this.cbbDrinkType.TabIndex = 1;
            this.cbbDrinkType.SelectedIndexChanged += new System.EventHandler(this.cbbDrinkType_SelectedIndexChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(116, 12);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(68, 28);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.Text = "_______";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(10, 12);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(100, 28);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Tổng tiền";
            // 
            // panelTables
            // 
            this.panelTables.AutoScroll = true;
            this.panelTables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTables.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelTables.Location = new System.Drawing.Point(9, 38);
            this.panelTables.Margin = new System.Windows.Forms.Padding(0);
            this.panelTables.Name = "panelTables";
            this.panelTables.Padding = new System.Windows.Forms.Padding(2);
            this.panelTables.Size = new System.Drawing.Size(355, 647);
            this.panelTables.TabIndex = 3;
            this.panelTables.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Location = new System.Drawing.Point(369, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 57);
            this.panel1.TabIndex = 9;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(833, 633);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(150, 52);
            this.btnCheckOut.TabIndex = 24;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // edtFoodName
            // 
            this.edtFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtFoodName.Location = new System.Drawing.Point(988, 74);
            this.edtFoodName.Name = "edtFoodName";
            this.edtFoodName.Size = new System.Drawing.Size(353, 29);
            this.edtFoodName.TabIndex = 25;
            this.edtFoodName.TextChanged += new System.EventHandler(this.edtFoodName_TextChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Location = new System.Drawing.Point(988, 110);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(353, 517);
            this.panelMenu.TabIndex = 26;
            // 
            // mnstrip
            // 
            this.mnstrip.AllowMerge = false;
            this.mnstrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(61)))), ((int)(((byte)(28)))));
            this.mnstrip.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnstrip.ForeColor = System.Drawing.Color.White;
            this.mnstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.mnstrip.Location = new System.Drawing.Point(0, 0);
            this.mnstrip.Name = "mnstrip";
            this.mnstrip.Size = new System.Drawing.Size(1353, 27);
            this.mnstrip.TabIndex = 27;
            this.mnstrip.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // btnCheckOutDisabled
            // 
            this.btnCheckOutDisabled.BackColor = System.Drawing.Color.DarkGray;
            this.btnCheckOutDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOutDisabled.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOutDisabled.ForeColor = System.Drawing.Color.DimGray;
            this.btnCheckOutDisabled.Location = new System.Drawing.Point(833, 632);
            this.btnCheckOutDisabled.Name = "btnCheckOutDisabled";
            this.btnCheckOutDisabled.Size = new System.Drawing.Size(150, 52);
            this.btnCheckOutDisabled.TabIndex = 28;
            this.btnCheckOutDisabled.Text = "Thanh toán";
            this.btnCheckOutDisabled.UseVisualStyleBackColor = false;
            // 
            // frmCoffeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1353, 697);
            this.Controls.Add(this.btnCheckOutDisabled);
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
            this.Controls.Add(this.mnstrip);
            this.MainMenuStrip = this.mnstrip;
            this.Name = "frmCoffeeManagement";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCoffeeManagement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnstrip.ResumeLayout(false);
            this.mnstrip.PerformLayout();
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
        private System.Windows.Forms.Label txtEmpty;
        private System.Windows.Forms.MenuStrip mnstrip;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnCheckOutDisabled;
    }
}