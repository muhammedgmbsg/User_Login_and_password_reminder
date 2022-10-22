using System;

namespace WindowsFormsApp2
{
    partial class Form1
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
            this.boxSifre = new System.Windows.Forms.TextBox();
            this.buttonGırıs = new System.Windows.Forms.Button();
            this.sifreUnut = new System.Windows.Forms.LinkLabel();
            this.boxAd = new System.Windows.Forms.TextBox();
            this.omar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxSifre
            // 
            this.boxSifre.BackColor = System.Drawing.Color.LightGray;
            this.boxSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxSifre.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxSifre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxSifre.Location = new System.Drawing.Point(615, 404);
            this.boxSifre.Multiline = true;
            this.boxSifre.Name = "boxSifre";
            this.boxSifre.PasswordChar = '*';
            this.boxSifre.Size = new System.Drawing.Size(259, 35);
            this.boxSifre.TabIndex = 1;
            this.boxSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonGırıs
            // 
            this.buttonGırıs.BackColor = System.Drawing.Color.Black;
            this.buttonGırıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGırıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGırıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGırıs.ForeColor = System.Drawing.Color.White;
            this.buttonGırıs.Location = new System.Drawing.Point(606, 467);
            this.buttonGırıs.Name = "buttonGırıs";
            this.buttonGırıs.Size = new System.Drawing.Size(268, 44);
            this.buttonGırıs.TabIndex = 2;
            this.buttonGırıs.Text = "Giriş Yap";
            this.buttonGırıs.UseVisualStyleBackColor = false;
            this.buttonGırıs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sifreUnut
            // 
            this.sifreUnut.ActiveLinkColor = System.Drawing.Color.White;
            this.sifreUnut.AutoSize = true;
            this.sifreUnut.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreUnut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sifreUnut.LinkColor = System.Drawing.Color.Black;
            this.sifreUnut.Location = new System.Drawing.Point(669, 545);
            this.sifreUnut.Name = "sifreUnut";
            this.sifreUnut.Size = new System.Drawing.Size(159, 33);
            this.sifreUnut.TabIndex = 3;
            this.sifreUnut.TabStop = true;
            this.sifreUnut.Text = "Şifremi unuttum";
            this.sifreUnut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifreUnut_LinkClicked);
            // 
            // boxAd
            // 
            this.boxAd.BackColor = System.Drawing.Color.LightGray;
            this.boxAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxAd.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxAd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxAd.Location = new System.Drawing.Point(615, 312);
            this.boxAd.Multiline = true;
            this.boxAd.Name = "boxAd";
            this.boxAd.Size = new System.Drawing.Size(259, 35);
            this.boxAd.TabIndex = 4;
            // 
            // omar
            // 
            this.omar.AutoSize = true;
            this.omar.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.omar.ForeColor = System.Drawing.Color.Red;
            this.omar.Location = new System.Drawing.Point(564, 305);
            this.omar.Name = "omar";
            this.omar.Size = new System.Drawing.Size(23, 35);
            this.omar.TabIndex = 5;
            this.omar.Text = " ";
            this.omar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1498, 651);
            this.Controls.Add(this.omar);
            this.Controls.Add(this.boxAd);
            this.Controls.Add(this.sifreUnut);
            this.Controls.Add(this.buttonGırıs);
            this.Controls.Add(this.boxSifre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxSifre;
        private System.Windows.Forms.Button buttonGırıs;
        private System.Windows.Forms.LinkLabel sifreUnut;
        private System.Windows.Forms.TextBox boxAd;
        private System.Windows.Forms.Label omar;
    }
}

