using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru6
{
    public partial class Form1 : Form
    {
        int siraNu = 0;
        Form2 aracBilgileri = new Form2();
        Form3 aracYerleri = new Form3();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Menü";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            aracBilgileri.Show();
            int siraNu = Convert.ToInt32(aracBilgileri.textBox9.Text);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            aracYerleri.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            StreamReader fileRead =new StreamReader("C:\\otopark.txt", Encoding.Default);//Türkçe karakter sorunu giderildi.

            string bilgiler = fileRead.ReadToEnd();
            string[] parcala = bilgiler.Split('#','\n');
            string[] plakalar = new string[parcala.Length/10];
            string[] parkYeri = new string[parcala.Length/10];
            aracBilgileri.parcala = parcala;
            for (int i=0;i<parcala.Length/10;i++)
            {
                aracBilgileri.textBox9.Text = parcala[i*10];//+"/" + parcala.Length
                aracBilgileri.maskedTextBox1.Text = parcala[i*10+1];
                aracBilgileri.textBox2.Text = parcala[i * 10 + 2];
                aracBilgileri.textBox3.Text = parcala[i * 10 + 3];
                aracBilgileri.maskedTextBox2.Text = parcala[i * 10 + 4];
                aracBilgileri.textBox5.Text = parcala[i * 10 + 5];
                aracYerleri.plaka = parcala[i * 10 + 5];
                plakalar[i]= parcala[i * 10 + 5];
                aracYerleri.plakalar[i] = plakalar[i];
                aracBilgileri.plakalar[i] = plakalar[i];
                aracBilgileri.textBox6.Text = parcala[i * 10 + 6];
                aracBilgileri.textBox7.Text = parcala[i * 10 + 7];
                aracBilgileri.textBox8.Text = parcala[i * 10 + 8];
                aracBilgileri.comboBox1.Text = parcala[i * 10 + 9];
                aracYerleri.bulunduguYer= parcala[i * 10 + 9];
                parkYeri[i] = parcala[i * 10 + 9];
                aracYerleri.bulunduguYerdizi[i] = parkYeri[i];
            }
            //button =>  <| 0 <i-1  >i+1 >| parcala.lengt
            aracBilgileri.sonSira = (parcala.Length / 10);



            fileRead.Close();
        }
    }
}
