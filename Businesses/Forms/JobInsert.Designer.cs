namespace Businesses.Forms
{
    partial class JobInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.JobTitleTB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MinSalaryTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxSalaryTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Job Title:";
            // 
            // JobTitleTB
            // 
            this.JobTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobTitleTB.Location = new System.Drawing.Point(61, 43);
            this.JobTitleTB.Name = "JobTitleTB";
            this.JobTitleTB.Size = new System.Drawing.Size(127, 26);
            this.JobTitleTB.TabIndex = 9;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(126, 193);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 8;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InsertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertBTN.Location = new System.Drawing.Point(27, 193);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(93, 38);
            this.InsertBTN.TabIndex = 6;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Min Salary:";
            // 
            // MinSalaryTB
            // 
            this.MinSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinSalaryTB.Location = new System.Drawing.Point(61, 96);
            this.MinSalaryTB.Name = "MinSalaryTB";
            this.MinSalaryTB.Size = new System.Drawing.Size(127, 26);
            this.MinSalaryTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Max Salary:";
            // 
            // MaxSalaryTB
            // 
            this.MaxSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxSalaryTB.Location = new System.Drawing.Point(61, 150);
            this.MaxSalaryTB.Name = "MaxSalaryTB";
            this.MaxSalaryTB.Size = new System.Drawing.Size(127, 26);
            this.MaxSalaryTB.TabIndex = 13;
            // 
            // JobInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxSalaryTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinSalaryTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JobTitleTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.InsertBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobInsert";
            this.Text = "JobInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JobTitleTB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinSalaryTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxSalaryTB;
    }
}