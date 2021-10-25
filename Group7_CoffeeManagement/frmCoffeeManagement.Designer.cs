
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.edtDrinkPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtDrinkID = new System.Windows.Forms.TextBox();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.nudDrinkQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtDrinkName = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.nudAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.cbbDrinkName = new System.Windows.Forms.ComboBox();
            this.cbbDrinkType = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.panelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnCheckOut);
            this.panel2.Controls.Add(this.nudAddQuantity);
            this.panel2.Controls.Add(this.lvOrder);
            this.panel2.Controls.Add(this.btnAddDrink);
            this.panel2.Controls.Add(this.cbbDrinkName);
            this.panel2.Controls.Add(this.cbbDrinkType);
            this.panel2.Location = new System.Drawing.Point(422, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 572);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(520, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 69);
            this.panel4.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(517, 503);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 69);
            this.button5.TabIndex = 22;
            this.button5.Text = "Chuyển bàn";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.edtDrinkPrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.edtDrinkID);
            this.panel3.Controls.Add(this.btnDeleteDrink);
            this.panel3.Controls.Add(this.btnUpdateOrder);
            this.panel3.Controls.Add(this.nudDrinkQuantity);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.edtDrinkName);
            this.panel3.Location = new System.Drawing.Point(517, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 413);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giá";
            // 
            // edtDrinkPrice
            // 
            this.edtDrinkPrice.Location = new System.Drawing.Point(3, 173);
            this.edtDrinkPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtDrinkPrice.Name = "edtDrinkPrice";
            this.edtDrinkPrice.Size = new System.Drawing.Size(206, 27);
            this.edtDrinkPrice.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID";
            // 
            // edtDrinkID
            // 
            this.edtDrinkID.Location = new System.Drawing.Point(3, 24);
            this.edtDrinkID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtDrinkID.Name = "edtDrinkID";
            this.edtDrinkID.Size = new System.Drawing.Size(206, 27);
            this.edtDrinkID.TabIndex = 23;
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Location = new System.Drawing.Point(3, 320);
            this.btnDeleteDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(62, 56);
            this.btnDeleteDrink.TabIndex = 21;
            this.btnDeleteDrink.Text = "Xóa";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(73, 320);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(137, 57);
            this.btnUpdateOrder.TabIndex = 20;
            this.btnUpdateOrder.Text = "Cập nhật";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // nudDrinkQuantity
            // 
            this.nudDrinkQuantity.Location = new System.Drawing.Point(5, 249);
            this.nudDrinkQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDrinkQuantity.Name = "nudDrinkQuantity";
            this.nudDrinkQuantity.Size = new System.Drawing.Size(206, 27);
            this.nudDrinkQuantity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên ";
            // 
            // edtDrinkName
            // 
            this.edtDrinkName.Location = new System.Drawing.Point(3, 100);
            this.edtDrinkName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtDrinkName.Name = "edtDrinkName";
            this.edtDrinkName.Size = new System.Drawing.Size(206, 27);
            this.edtDrinkName.TabIndex = 17;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(401, 503);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(105, 69);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // nudAddQuantity
            // 
            this.nudAddQuantity.Location = new System.Drawing.Point(305, 37);
            this.nudAddQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAddQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAddQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddQuantity.Name = "nudAddQuantity";
            this.nudAddQuantity.Size = new System.Drawing.Size(109, 27);
            this.nudAddQuantity.TabIndex = 7;
            this.nudAddQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lvOrder
            // 
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(0, 77);
            this.lvOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(506, 412);
            this.lvOrder.TabIndex = 4;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(421, -1);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(86, 69);
            this.btnAddDrink.TabIndex = 3;
            this.btnAddDrink.Text = "Thêm";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            // 
            // cbbDrinkName
            // 
            this.cbbDrinkName.FormattingEnabled = true;
            this.cbbDrinkName.Location = new System.Drawing.Point(0, 39);
            this.cbbDrinkName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDrinkName.Name = "cbbDrinkName";
            this.cbbDrinkName.Size = new System.Drawing.Size(297, 28);
            this.cbbDrinkName.TabIndex = 2;
            // 
            // cbbDrinkType
            // 
            this.cbbDrinkType.FormattingEnabled = true;
            this.cbbDrinkType.Location = new System.Drawing.Point(0, 0);
            this.cbbDrinkType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDrinkType.Name = "cbbDrinkType";
            this.cbbDrinkType.Size = new System.Drawing.Size(413, 28);
            this.cbbDrinkType.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(96, 13);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(109, 28);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.Text = "50.000 vnd";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(3, 13);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(95, 28);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Tổng tiền";
            // 
            // panelTables
            // 
            this.panelTables.Location = new System.Drawing.Point(14, 15);
            this.panelTables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(401, 575);
            this.panelTables.TabIndex = 3;
            //this.panelTables.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTables_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Location = new System.Drawing.Point(422, 519);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 69);
            this.panel1.TabIndex = 9;
            // 
            // frmCoffeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCoffeeManagement";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudAddQuantity;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.ComboBox cbbDrinkName;
        private System.Windows.Forms.ComboBox cbbDrinkType;
        private System.Windows.Forms.FlowLayoutPanel tablePanel;
        private System.Windows.Forms.FlowLayoutPanel panelTables;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtDrinkPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtDrinkID;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.NumericUpDown nudDrinkQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtDrinkName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}