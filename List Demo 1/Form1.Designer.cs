namespace List_Demo_1
{
    partial class Time_Zones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time_Zones));
            this.lbxCities = new System.Windows.Forms.ListBox();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCities
            // 
            this.lbxCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.ItemHeight = 16;
            this.lbxCities.Items.AddRange(new object[] {
            "San Francisco",
            "New York City",
            "Dover",
            "Pittsburgh",
            "Paris",
            "Hyrule",
            "Jimmy Johns City",
            "Hankville",
            "North Korea",
            "Obamanation"});
            this.lbxCities.Location = new System.Drawing.Point(71, 51);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.Size = new System.Drawing.Size(136, 68);
            this.lbxCities.TabIndex = 0;
            this.lbxCities.SelectedIndexChanged += new System.EventHandler(this.lblCities_SelectedIndexChanged);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(21, 158);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(42, 16);
            this.lblTime1.TabIndex = 1;
            this.lblTime1.Text = "Time:";
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeZone.Location = new System.Drawing.Point(71, 152);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(76, 29);
            this.lblTimeZone.TabIndex = 2;
            this.lblTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeZone.Click += new System.EventHandler(this.lblTimeZone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a City and See the Time:";
            // 
            // Time_Zones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.lbxCities);
            this.Name = "Time_Zones";
            this.Text = "Time Zones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCities;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Label label1;
    }
}

