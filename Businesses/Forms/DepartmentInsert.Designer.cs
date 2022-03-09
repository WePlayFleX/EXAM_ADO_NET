namespace Businesses.Forms
{
    partial class DepartmentInsert
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
            this.InsertBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label345.Location = new System.Drawing.Point(58, 76);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(95, 20);
            this.label345.TabIndex = 11;
            this.label345.Text = "Location ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Department name:";
            // 
            // DepartmentNameTB
            // 
            this.DepartmentNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentNameTB.Location = new System.Drawing.Point(62, 47);
            this.DepartmentNameTB.Name = "DepartmentNameTB";
            this.DepartmentNameTB.Size = new System.Drawing.Size(127, 26);
            this.DepartmentNameTB.TabIndex = 9;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(121, 158);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 8;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // LocationsCB
            // 
            this.LocationsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationsCB.FormattingEnabled = true;
            this.LocationsCB.Location = new System.Drawing.Point(62, 99);
            this.LocationsCB.Name = "LocationsCB";
            this.LocationsCB.Size = new System.Drawing.Size(121, 28);
            this.LocationsCB.TabIndex = 7;
            // 
            // InsertBTN
            // 
            this.InsertBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InsertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertBTN.Location = new System.Drawing.Point(22, 158);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(93, 38);
            this.InsertBTN.TabIndex = 6;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // DepartmentInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 249);
            this.Controls.Add(this.label345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentNameTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.LocationsCB);
            this.Controls.Add(this.InsertBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentInsert";
            this.Text = "DepartmentsInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label345;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepartmentNameTB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.ComboBox LocationsCB;
        private System.Windows.Forms.Button InsertBTN;
    }
}