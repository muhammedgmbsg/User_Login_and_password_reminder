using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        public string conString = "Data Source=DESKTOP-5JKEFQ1\\SQLEXPRESS; Initial Catalog= OrnekDb; Integrated Security= True";
        public string b = "select * from Kullanici_Bilgi";
        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();


            SqlCommand cmd = new SqlCommand(b, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool sonuc = false;
            while (dr.Read())
            {
                if (dr["var"].ToString().Trim() == boxAd.Text && dr["sifre"].ToString().Trim() == boxSifre.Text)
                {
                    sonuc = true;
                    break;
                }
            }
            if (sonuc)
            {
                MessageBox.Show("Giriş Başarılı", "Bilgi");
                Application.Exit();


            }
            else
            {
                MessageBox.Show("Giriş Başarısız", "Bilgi");
            }
        }
            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sifreUnut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

         //   if (boxSifre.Text != "")
          //  {

                Sifre sayfa2 = new Sifre();
                sayfa2.ShowDialog();
           // }
           // else
           // {
          //      MessageBox.Show("Kullanıcı adı girmediniz.", "Bilgi");
          //  }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
