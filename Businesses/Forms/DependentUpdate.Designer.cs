namespace Businesses.Forms
{
    partial class DependentUpdate
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
            this.EmployeeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RelationshipTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label345.Location = new System.Drawing.Point(48, 171);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(104, 20);
            this.label345.TabIndex = 34;
            this.label345.Text = "Employee ID:";
            // 
            // EmployeeCB
            // 
            this.EmployeeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeCB.FormattingEnabled = true;
            this.EmployeeCB.Location = new System.Drawing.Point(52, 194);
            this.EmployeeCB.Name = "EmployeeCB";
            this.EmployeeCB.Size = new System.Drawing.Size(127, 28);
            this.EmployeeCB.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Relationship:";
            // 
            // RelationshipTB
            // 
            this.RelationshipTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelationshipTB.Location = new System.Drawing.Point(52, 142);
            this.RelationshipTB.Name = "RelationshipTB";
            this.RelationshipTB.Size = new System.Drawing.Size(127, 26);
            this.RelationshipTB.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last Name:";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTB.Location = new System.Drawing.Point(52, 88);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(127, 26);
            this.LastNameTB.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "First Name:";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTB.Location = new System.Drawing.Point(52, 35);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(127, 26);
            this.FirstNameTB.TabIndex = 27;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(114, 238);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 26;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBTN.Location = new System.Drawing.Point(15, 238);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(93, 38);
            this.UpdateBTN.TabIndex = 25;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // DependentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 291);
            this.Controls.Add(this.label345);
            this.Controls.Add(this.EmployeeCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RelationshipTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.UpdateBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DependentUpdate";
            this.Text = "DependentUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label345;
        private System.Windows.Forms.ComboBox EmployeeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RelationshipTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button UpdateBTN;
    }
}