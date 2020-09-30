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

namespace DatabaseBilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EREN\\SQLEXPRESS;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        int puan = 0;
        int dogru = 0;
        int yanlis = 0;
        int sure = 0;
        
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 21;
            button1.BackColor = DefaultBackColor;
            button2.BackColor = DefaultBackColor;
            button3.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "İleri";
            sayac++;
            label1.Text = sayac.ToString();

            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *from Yarisma.dbo.soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["asik"].ToString();
                    button2.Text = oku["bsik"].ToString();
                    button3.Text = oku["csik"].ToString();
                    button4.Text = oku["dsik"].ToString();
                    label8.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if(sayac==8)
            {
                timer1.Stop();
                label1.Text = " ";
                textBox1.Text = " ";
                button1.Text = " ";
                button2.Text = " "; 
                button3.Text = " ";
                button4.Text = " ";
                label8.Text = " ";
                button5.Text = " ";
                MessageBox.Show("Yarışma bitti! Puanınız: '"+puan+"'");
                Application.Exit();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {  

            label1.Text = sayac.ToString();
            label8.Visible = false;
            label9.Visible = false;
            button1.BackColor = DefaultBackColor;
            button2.BackColor = DefaultBackColor;
            button3.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(button1.Text==label8.Text)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = DefaultBackColor;
                button3.BackColor = DefaultBackColor;
                button4.BackColor = DefaultBackColor;
                puan = puan + 10;
                label6.Text = puan.ToString();
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                yanlis++;
                label14.Text = yanlis.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(button2.Text==label8.Text)
            {
                button1.BackColor = DefaultBackColor;
                button2.BackColor = Color.Green;
                button3.BackColor = DefaultBackColor;
                button4.BackColor = DefaultBackColor;

                puan = puan + 10;
                label6.Text = puan.ToString();
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                yanlis++;
                label14.Text = yanlis.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(button3.Text==label8.Text)
            {
                button1.BackColor = DefaultBackColor;
                button2.BackColor = DefaultBackColor;
                button3.BackColor = Color.Green;
                button4.BackColor = DefaultBackColor;
                puan = puan + 10;
                label6.Text = puan.ToString();
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                yanlis++;
                label14.Text = yanlis.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(button4.Text==label8.Text)
            {
                button1.BackColor = DefaultBackColor;
                button2.BackColor = DefaultBackColor;
                button3.BackColor = DefaultBackColor;
                button4.BackColor = Color.Green;
                puan = puan + 10;
                label6.Text = puan.ToString();
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                yanlis++;
                label14.Text = yanlis.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sure = sure - 1;
            label2.Text = sure.ToString();
            if(sure==0)
            {
                timer1.Stop();
                MessageBox.Show("Maalesef süreniz bitti!");
                Application.Exit();
            }
      
        }
    }
}
