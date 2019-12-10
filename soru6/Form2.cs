using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru6
{
    public partial class Form2 : Form
    {
       // Form1 menuu = new Form1();
        Form3 aracYerlerii = new Form3();

        public int sonSira=0;
        public string plaka = "";
        public string[] plakalar = new String[13];
        public string[] parcala;
        int numara = 0;
        public Form2()
        {
            InitializeComponent();
            this.Text = "AracBilgileriForm";
        }
        
        public void Form2_Load(object sender, EventArgs e)
        {

           // textBox1.Text = "";
           for (int i = numara*10; i < plakalar.Length; i++)
           {
               plaka = plakalar[i];
               textBox9.Text = parcala[i * 10];
               maskedTextBox1.Text = parcala[i * 10 + 1];
               textBox2.Text = parcala[i * 10 + 2];
               textBox3.Text = parcala[i * 10 + 3];
               maskedTextBox2.Text = parcala[i * 10 + 4];
               textBox5.Text = parcala[i * 10 + 5];
               plakalar[i] = plakalar[i];
               textBox6.Text = parcala[i * 10 + 6];
               textBox7.Text = parcala[i * 10 + 7];
               textBox8.Text = parcala[i * 10 + 8];
               comboBox1.Text = parcala[i * 10 + 9];
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // anaMenu.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aracYerlerii.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int odeme = 0,sure=0,temizlik=0;
            

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                
                switch (checkedListBox1.CheckedItems[i].ToString())
                {
                    case "İç Temizlik (10TL)":
                        temizlik += 10;
                        break;
                    case "Dış Temizlik (10TL)":
                        temizlik += 10;
                        break;
                    default:
                        MessageBox.Show("Hiç seçim yapılmadı, dolayısıyla 0 TL temizlik.");
                        break;
                }
            }

            
            if (comboBox2.SelectedIndex == 0)
            {
                sure = 0;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                sure = 2;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                sure = 3;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                sure = 5;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                sure = 10;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                sure = 15;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                sure = 25;
            }

            
            odeme = sure+temizlik;
            MessageBox.Show(plaka+" "+odeme+" TL ödeme için teşekkür ederiz.\nYine Bekleriz, Güle Güle.");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            numara = Convert.ToInt32(textBox9.Text);
            if (numara > 1)
            {
                numara -= 1;
            }
            else
            {
                MessageBox.Show("Yanlış Değer Girdiniz!");
            }
            textBox9.Text = numara.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numara = Convert.ToInt32(textBox9.Text);
            if (numara < 20)
            {
                numara += 1;
            }
            else
            {
                MessageBox.Show("Otopark Kapasitesi 20'dir!");
            }
            textBox9.Text = numara.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox9.Text = sonSira.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Text = "1";
        }

    }
}
