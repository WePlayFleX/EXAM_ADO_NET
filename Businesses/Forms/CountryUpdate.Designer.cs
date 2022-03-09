namespace Businesses.Forms
{
    partial class CountryUpdate
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
            this.CountryNameTB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.RegionsCB = new System.Windows.Forms.ComboBox();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label345.Location = new System.Drawing.Point(55, 75);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(85, 20);
            this.label345.TabIndex = 11;
            this.label345.Text = "Region ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Country Name:";
            // 
            // CountryNameTB
            // 
            this.CountryNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryNameTB.Location = new System.Drawing.Point(59, 46);
            this.CountryNameTB.Name = "CountryNameTB";
            this.CountryNameTB.Size = new System.Drawing.Size(127, 26);
            this.CountryNameTB.TabIndex = 9;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(118, 157);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 8;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // RegionsCB
            // 
            this.RegionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionsCB.FormattingEnabled = true;
            this.RegionsCB.Location = new System.Drawing.Point(59, 98);
            this.RegionsCB.Name = "RegionsCB";
            this.RegionsCB.Size = new System.Drawing.Size(121, 28);
            this.RegionsCB.TabIndex = 7;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBTN.Location = new System.Drawing.Point(19, 157);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(93, 38);
            this.UpdateBTN.TabIndex = 6;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // CountryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 212);
            this.Controls.Add(this.label345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryNameTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.RegionsCB);
            this.Controls.Add(this.UpdateBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountryUpdate";
            this.Text = "CountryUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label345;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountryNameTB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.ComboBox RegionsCB;
        private System.Windows.Forms.Button UpdateBTN;
    }
}