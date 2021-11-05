
namespace Group7_CoffeeManagement
{
    partial class frmNewTable
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 15);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 125);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 15);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(56, 122);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(151, 23);
            this.txtStatus.TabIndex = 5;
            // 
            // frmNewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 248);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmNewTable";
            this.Text = "frmNewTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStatus;
    }
}