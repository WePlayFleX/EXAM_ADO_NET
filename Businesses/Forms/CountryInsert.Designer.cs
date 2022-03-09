namespace Businesses.Forms
{
    partial class CountryInsert
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
            this.InsertBTN = new System.Windows.Forms.Button();
            this.RegionsCB = new System.Windows.Forms.ComboBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.CountryNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label345 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertBTN
            // 
            this.InsertBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InsertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertBTN.Location = new System.Drawing.Point(18, 154);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(93, 38);
            this.InsertBTN.TabIndex = 0;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // RegionsCB
            // 
            this.RegionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionsCB.FormattingEnabled = true;
            this.RegionsCB.Location = new System.Drawing.Point(58, 95);
            this.RegionsCB.Name = "RegionsCB";
            this.RegionsCB.Size = new System.Drawing.Size(121, 28);
            this.RegionsCB.TabIndex = 1;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBTN.Location = new System.Drawing.Point(117, 154);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(93, 38);
            this.CancelBTN.TabIndex = 2;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // CountryNameTB
            // 
            this.CountryNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryNameTB.Location = new System.Drawing.Point(58, 43);
            this.CountryNameTB.Name = "CountryNameTB";
            this.CountryNameTB.Size = new System.Drawing.Size(127, 26);
            this.CountryNameTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Country Name:";
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label345.Location = new System.Drawing.Point(54, 72);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(85, 20);
            this.label345.TabIndex = 5;
            this.label345.Text = "Region ID:";
            // 
            // CountryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 210);
            this.Controls.Add(this.label345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryNameTB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.RegionsCB);
            this.Controls.Add(this.InsertBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountryInsert";
            this.Text = "InsertCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.ComboBox RegionsCB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox CountryNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label345;
    }
}