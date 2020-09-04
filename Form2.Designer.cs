namespace WSJR_sim
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.LDL = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.clearbelow = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.heatindex = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.dewpoint = new System.Windows.Forms.Label();
            this.bp = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.visib = new System.Windows.Forms.Label();
            this.precip = new System.Windows.Forms.Label();
            this.timeanddate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LDL
            // 
            this.LDL.AutoSize = true;
            this.LDL.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDL.ForeColor = System.Drawing.Color.White;
            this.LDL.Location = new System.Drawing.Point(57, 368);
            this.LDL.Name = "LDL";
            this.LDL.Size = new System.Drawing.Size(315, 36);
            this.LDL.TabIndex = 15;
            this.LDL.Text = "Conditions At Sidney";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("STAR JR Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(418, 357);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(151, 16);
            this.LabelTime.TabIndex = 14;
            this.LabelTime.Text = "--:--:-- AM";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("STAR JR Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.White;
            this.LabelDate.Location = new System.Drawing.Point(60, 357);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(151, 16);
            this.LabelDate.TabIndex = 13;
            this.LabelDate.Text = "Sun Jan 1st";
            this.LabelDate.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-5, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(48, 34);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(315, 36);
            this.header.TabIndex = 16;
            this.header.Text = "Conditions At Sidney";
            // 
            // clearbelow
            // 
            this.clearbelow.AutoSize = true;
            this.clearbelow.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbelow.ForeColor = System.Drawing.Color.White;
            this.clearbelow.Location = new System.Drawing.Point(48, 72);
            this.clearbelow.Name = "clearbelow";
            this.clearbelow.Size = new System.Drawing.Size(330, 36);
            this.clearbelow.TabIndex = 17;
            this.clearbelow.Text = "Clear Below 12,000 ft";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.Color.White;
            this.temp.Location = new System.Drawing.Point(48, 108);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(165, 36);
            this.temp.TabIndex = 18;
            this.temp.Text = "Temp: 83°F";
            // 
            // heatindex
            // 
            this.heatindex.AutoSize = true;
            this.heatindex.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heatindex.ForeColor = System.Drawing.Color.White;
            this.heatindex.Location = new System.Drawing.Point(274, 108);
            this.heatindex.Name = "heatindex";
            this.heatindex.Size = new System.Drawing.Size(255, 36);
            this.heatindex.TabIndex = 19;
            this.heatindex.Text = "Heat Index: 81°F";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.ForeColor = System.Drawing.Color.White;
            this.humidity.Location = new System.Drawing.Point(50, 144);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(225, 36);
            this.humidity.TabIndex = 20;
            this.humidity.Text = "Humidity:  25%";
            // 
            // dewpoint
            // 
            this.dewpoint.AutoSize = true;
            this.dewpoint.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dewpoint.ForeColor = System.Drawing.Color.White;
            this.dewpoint.Location = new System.Drawing.Point(304, 144);
            this.dewpoint.Name = "dewpoint";
            this.dewpoint.Size = new System.Drawing.Size(225, 36);
            this.dewpoint.TabIndex = 21;
            this.dewpoint.Text = "Dewpoint: 44°F";
            // 
            // bp
            // 
            this.bp.AutoSize = true;
            this.bp.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bp.ForeColor = System.Drawing.Color.White;
            this.bp.Location = new System.Drawing.Point(48, 180);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(465, 36);
            this.bp.TabIndex = 22;
            this.bp.Text = "Barometric Pressure: 30.06 in ";
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind.ForeColor = System.Drawing.Color.White;
            this.wind.Location = new System.Drawing.Point(48, 216);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(255, 36);
            this.wind.TabIndex = 23;
            this.wind.Text = "Wind: W    5 MPH";
            // 
            // visib
            // 
            this.visib.AutoSize = true;
            this.visib.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visib.ForeColor = System.Drawing.Color.White;
            this.visib.Location = new System.Drawing.Point(48, 252);
            this.visib.Name = "visib";
            this.visib.Size = new System.Drawing.Size(495, 36);
            this.visib.TabIndex = 24;
            this.visib.Text = "Visib:  10 mi. Ceiling Unlimited";
            // 
            // precip
            // 
            this.precip.AutoSize = true;
            this.precip.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precip.ForeColor = System.Drawing.Color.White;
            this.precip.Location = new System.Drawing.Point(48, 288);
            this.precip.Name = "precip";
            this.precip.Size = new System.Drawing.Size(435, 36);
            this.precip.TabIndex = 25;
            this.precip.Text = "June Precipitation: 0.59 in.";
            // 
            // timeanddate
            // 
            this.timeanddate.Enabled = true;
            this.timeanddate.Interval = 30;
            this.timeanddate.Tick += new System.EventHandler(this.Wait_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(2)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.precip);
            this.Controls.Add(this.visib);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.dewpoint);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.heatindex);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.clearbelow);
            this.Controls.Add(this.header);
            this.Controls.Add(this.LDL);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDL;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label clearbelow;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label heatindex;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label dewpoint;
        private System.Windows.Forms.Label bp;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label visib;
        private System.Windows.Forms.Label precip;
        private System.Windows.Forms.Timer timeanddate;
    }
}