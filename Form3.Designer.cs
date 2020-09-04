namespace WSJR_sim
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.LDL = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LDL
            // 
            this.LDL.AutoSize = true;
            this.LDL.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDL.ForeColor = System.Drawing.Color.White;
            this.LDL.Location = new System.Drawing.Point(57, 368);
            this.LDL.Name = "LDL";
            this.LDL.Size = new System.Drawing.Size(405, 36);
            this.LDL.TabIndex = 17;
            this.LDL.Text = "Conditions At Shohola Twp.";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("STAR JR Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(418, 357);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(151, 16);
            this.LabelTime.TabIndex = 16;
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
            this.LabelDate.TabIndex = 15;
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
            this.label3.TabIndex = 14;
            this.label3.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("STAR JR", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(37, 75);
            this.data.MaximumSize = new System.Drawing.Size(550, 255);
            this.data.MinimumSize = new System.Drawing.Size(550, 255);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(550, 255);
            this.data.TabIndex = 13;
            this.data.Text = resources.GetString("data.Text");
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("STAR JR Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.header.Location = new System.Drawing.Point(97, 33);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(428, 18);
            this.header.TabIndex = 12;
            this.header.Text = "Nat\'l Weather Service Forecast";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(2)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.LDL);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.header);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDL;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label header;
    }
}