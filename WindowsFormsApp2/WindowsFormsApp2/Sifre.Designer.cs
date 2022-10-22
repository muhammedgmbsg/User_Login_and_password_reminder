namespace WindowsFormsApp2
{
    partial class Sifre
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
            this.BoxAd = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxTelefon = new System.Windows.Forms.TextBox();
            this.buttonGırıs = new System.Windows.Forms.Button();
            this.boxTarih = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoxAd
            // 
            this.BoxAd.BackColor = System.Drawing.Color.LightGray;
            this.BoxAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxAd.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxAd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BoxAd.Location = new System.Drawing.Point(617, 273);
            this.BoxAd.Multiline = true;
            this.BoxAd.Name = "BoxAd";
            this.BoxAd.Size = new System.Drawing.Size(259, 35);
            this.BoxAd.TabIndex = 2;
            // 
            // boxEmail
            // 
            this.boxEmail.BackColor = System.Drawing.Color.LightGray;
            this.boxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxEmail.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxEmail.Location = new System.Drawing.Point(617, 273);
            this.boxEmail.Multiline = true;
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(259, 35);
            this.boxEmail.TabIndex = 2;
            // 
            // boxTelefon
            // 
            this.boxTelefon.BackColor = System.Drawing.Color.LightGray;
            this.boxTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxTelefon.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxTelefon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxTelefon.Location = new System.Drawing.Point(617, 373);
            this.boxTelefon.Multiline = true;
            this.boxTelefon.Name = "boxTelefon";
            this.boxTelefon.Size = new System.Drawing.Size(259, 35);
            this.boxTelefon.TabIndex = 2;
            // 
            // buttonGırıs
            // 
            this.buttonGırıs.BackColor = System.Drawing.Color.Black;
            this.buttonGırıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGırıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGırıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGırıs.ForeColor = System.Drawing.Color.White;
            this.buttonGırıs.Location = new System.Drawing.Point(624, 561);
            this.buttonGırıs.Name = "buttonGırıs";
            this.buttonGırıs.Size = new System.Drawing.Size(252, 34);
            this.buttonGırıs.TabIndex = 3;
            this.buttonGırıs.Text = "Şifre Al";
            this.buttonGırıs.UseVisualStyleBackColor = false;
            this.buttonGırıs.Click += new System.EventHandler(this.buttonGırıs_Click);
            // 
            // boxTarih
            // 
            this.boxTarih.BackColor = System.Drawing.Color.LightGray;
            this.boxTarih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxTarih.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxTarih.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxTarih.Location = new System.Drawing.Point(617, 473);
            this.boxTarih.Multiline = true;
            this.boxTarih.Name = "boxTarih";
            this.boxTarih.Size = new System.Drawing.Size(259, 35);
            this.boxTarih.TabIndex = 2;
            // 
            // Sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Sarı_Yıldızlı_İfade_Yatay_İlham_Verici_Mem__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1471, 642);
            this.Controls.Add(this.buttonGırıs);
            this.Controls.Add(this.boxTarih);
            this.Controls.Add(this.boxTelefon);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.BoxAd);
            this.DoubleBuffered = true;
            this.Name = "Sifre";
            this.Text = "Sifre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxAd;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxTelefon;
        private System.Windows.Forms.Button buttonGırıs;
        private System.Windows.Forms.TextBox boxTarih;
    }
}