namespace Businesses.Forms
{
    partial class DepartmentUpdate
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
            this.label345 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentNameTB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.LocationsCB = new System.Windows.Forms.ComboBox();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label345.Location = new System.Drawing.Point(52, 71);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(95, 20);
            this.label345.TabIndex = 17;
            this.label345.Text = "Location ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department name:";
            // 
            // DepartmentNameTB
            // 
            this.DepartmentNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentNameTB.Location = new System.Drawing.Point(56, 42);
            this.DepartmentNameTB.Name = "DepartmentNameTB";
            this.DepartmentNameTB.Size = new System.Drawing.Size(127, 26);
            this.DepartmentNameTB.TabIndex = 15;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(115, 153);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 14;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // LocationsCB
            // 
            this.LocationsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationsCB.FormattingEnabled = true;
            this.LocationsCB.Location = new System.Drawing.Point(56, 94);
            this.LocationsCB.Name = "LocationsCB";
            this.LocationsCB.Size = new System.Drawing.Size(121, 28);
            this.LocationsCB.TabIndex = 13;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBTN.Location = new System.Drawing.Point(16, 153);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(93, 38);
            this.UpdateBTN.TabIndex = 12;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // DepartmentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 207);
            this.Controls.Add(this.label345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentNameTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.LocationsCB);
            this.Controls.Add(this.UpdateBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentUpdate";
            this.Text = "DepartmentUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label345;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepartmentNameTB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.ComboBox LocationsCB;
        private System.Windows.Forms.Button UpdateBTN;
    }
}