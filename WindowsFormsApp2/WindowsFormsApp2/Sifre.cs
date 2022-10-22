using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class Sifre : Form
    {
        public Sifre()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=DESKTOP-5JKEFQ1\\SQLEXPRESS; Initial Catalog= OrnekDb; Integrated Security= True";
        public string b = "select * from Kullanici_Bilgi";
        private void buttonGırıs_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            SqlCommand cmd = new SqlCommand(b, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool sonuc = false;
            while (dr.Read())
            {
                if (dr["eposta"].ToString().Trim() == boxEmail.Text && dr["telefon"].ToString().Trim() == boxTelefon.Text)
                {
                    sonuc = true;
                    break;
                }
            }
            if (sonuc)
            {
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                String tarih = DateTime.Now.ToLongDateString();
                String mailadresin = ("scream.muhammedfethi@gmail.com");
                String sifre = ("sdcdknzzkfnkiehp");
                String smptserver = "smtp.gmail.com";
                String kime = (dr["eposta"].ToString());
                String konu = ("Şifre Hatırlatma Maili");
                String yaz = (tarih + " Sistemdeki Bilgileriniz: " + "\n" +"Kullanıcı Adınız: " + dr["var"]  + "\n" + "Parolanız: " + dr["sifre"].ToString() + "\nŞifrenizi kullanarak sisteme giriş yapabilirsiniz.");
                smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smptserver;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadresin);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;
                smtpserver.Send(mail);
                DialogResult bilgi = new DialogResult();


                MessageBox.Show("Şifre hatırlatma mesajı e posta adresinize gönderildi", "Bilgi");
                Application.Exit();

            }
            else
            {
                MessageBox.Show("Bilgiler eşleşmiyor tekrar deneyin", "Bilgi");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
