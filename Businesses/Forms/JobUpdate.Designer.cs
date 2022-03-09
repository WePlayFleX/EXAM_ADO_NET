namespace Businesses.Forms
{
    partial class JobUpdate
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
            this.label3 = new System.Windows.Forms.Label();
            this.MaxSalaryTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MinSalaryTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JobTitleTB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Max Salary:";
            // 
            // MaxSalaryTB
            // 
            this.MaxSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxSalaryTB.Location = new System.Drawing.Point(49, 149);
            this.MaxSalaryTB.Name = "MaxSalaryTB";
            this.MaxSalaryTB.Size = new System.Drawing.Size(127, 26);
            this.MaxSalaryTB.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Min Salary:";
            // 
            // MinSalaryTB
            // 
            this.MinSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinSalaryTB.Location = new System.Drawing.Point(49, 95);
            this.MinSalaryTB.Name = "MinSalaryTB";
            this.MinSalaryTB.Size = new System.Drawing.Size(127, 26);
            this.MinSalaryTB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Job Title:";
            // 
            // JobTitleTB
            // 
            this.JobTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobTitleTB.Location = new System.Drawing.Point(49, 42);
            this.JobTitleTB.Name = "JobTitleTB";
            this.JobTitleTB.Size = new System.Drawing.Size(127, 26);
            this.JobTitleTB.TabIndex = 17;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(114, 192);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 16;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBTN.Location = new System.Drawing.Point(15, 192);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(93, 38);
            this.UpdateBTN.TabIndex = 15;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // JobUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxSalaryTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinSalaryTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JobTitleTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.UpdateBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobUpdate";
            this.Text = "JobUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxSalaryTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinSalaryTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JobTitleTB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button UpdateBTN;
    }
}