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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Araç Yerleri";
        }

        public string bulunduguYer="";
        public string[] bulunduguYerdizi=new String[13];
        public string plaka="";
        public string[] plakalar = new String[13];
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bulunduguYerdizi.Length; i++)
            {
                bulunduguYer = bulunduguYerdizi[i];
                plaka = plakalar[i];
                //MessageBox.Show("bulundugu "+bulunduguYer+" plaka "+plaka);
                if (bulunduguYer == "A5")
                {
                    button3.BackColor = Color.Red;
                    button3.Text = plaka;
                }
                else
                {
                    button3.BackColor = Color.Chartreuse;
                    button3.Text = "A5";
                }
                if (bulunduguYer == "A4")
                {
                    this.BackColor = Color.Red;
                    button4.Text = plaka;
                }
                else
                {
                    button4.BackColor = Color.Chartreuse;
                    button4.Text = "A4";
                }
                if (bulunduguYer == "A3")
                {
                    this.BackColor = Color.Red;
                    button5.Text = plaka;
                }
                else
                {
                    button5.BackColor = Color.Chartreuse;
                    button5.Text = "A3";
                }
                if (bulunduguYer == "A2")
                {
                    this.BackColor = Color.Red;
                    button6.Text = plaka;
                }
                else
                {
                    button6.BackColor = Color.Chartreuse;
                    button6.Text = "A2";
                }
                if (bulunduguYer == "A1")
                {
                    this.BackColor = Color.Red;
                    button7.Text = plaka;
                }
                else
                {
                    button7.BackColor = Color.Chartreuse;
                    button7.Text = "A1";
                }
                if (bulunduguYer == "B5")
                {
                    this.BackColor = Color.Red;
                    button8.Text = plaka;
                }
                else
                {
                    button8.BackColor = Color.Chartreuse;
                    button8.Text = "B5";
                }
                if (bulunduguYer == "B4")
                {
                    this.BackColor = Color.Red;
                    button9.Text = plaka;
                }
                else
                {
                    button9.BackColor = Color.Chartreuse;
                    button9.Text = "B4";
                }
                if (bulunduguYer == "B3")
                {
                    this.BackColor = Color.Red;
                    button10.Text = plaka;
                }
                else
                {
                    button10.BackColor = Color.Chartreuse;
                    button10.Text = "B3";
                }
                if (bulunduguYer == "B2")
                {
                    this.BackColor = Color.Red;
                    button11.Text = plaka;
                }
                else
                {
                    button11.BackColor = Color.Chartreuse;
                    button11.Text = "B2";
                }
                if (bulunduguYer == "B1")
                {
                    this.BackColor = Color.Red;
                    button12.Text = plaka;
                }
                else
                {
                    button12.BackColor = Color.Chartreuse;
                    button12.Text = "B1";
                }
                if (bulunduguYer == "C5")
                {
                    this.BackColor = Color.Red;
                    button13.Text = plaka;
                }
                else
                {
                    button13.BackColor = Color.Chartreuse;
                    button13.Text = "C5";
                }
                if (bulunduguYer == "C4")
                {
                    this.BackColor = Color.Red;
                    button14.Text = plaka;
                }
                else
                {
                    button14.BackColor = Color.Chartreuse;
                    button14.Text = "C4";
                }
                if (bulunduguYer == "C3")
                {
                    this.BackColor = Color.Red;
                    button15.Text = plaka;
                }
                else
                {
                    button15.BackColor = Color.Chartreuse;
                    button15.Text = "C3";
                }
                if (bulunduguYer == "C2")
                {
                    this.BackColor = Color.Red;
                    button16.Text = plaka;
                }
                else
                {
                    button16.BackColor = Color.Chartreuse;
                    button16.Text = "C2";
                }
                if (bulunduguYer == "C1")
                {
                    this.BackColor = Color.Red;
                    button17.Text = plaka;
                }
                else
                {
                    button17.BackColor = Color.Chartreuse;
                    button17.Text = "C1";
                }
                if (bulunduguYer == "D5")
                {
                    this.BackColor = Color.Red;
                    button18.Text = plaka;
                }
                else
                {
                    button18.BackColor = Color.Chartreuse;
                    button18.Text = "D5";
                }
                if (bulunduguYer == "D4")
                {
                    this.BackColor = Color.Red;
                    button3.Text = plaka;
                }
                else
                {
                    button19.BackColor = Color.Chartreuse;
                    button19.Text = "D4";
                }
                if (bulunduguYer == "D3")
                {
                    this.BackColor = Color.Red;
                    button20.Text = plaka;
                }
                else
                {
                    button20.BackColor = Color.Chartreuse;
                    button20.Text = "D3";
                }
                if (bulunduguYer == "D2")
                {
                    this.BackColor = Color.Red;
                    button21.Text = plaka;
                }
                else
                {
                    button21.BackColor = Color.Chartreuse;
                    button21.Text = "D2";
                }
                if (bulunduguYer == "D1")
                {
                    button22.BackColor = Color.Red;
                    button22.Text = plaka;
                }
                else
                {
                    button22.BackColor = Color.Chartreuse;
                    button22.Text = "D1";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "A5")
            {
                button3.BackColor = Color.Red;
                button3.Text = plaka;
            }
            else
            {
                button3.BackColor = Color.Chartreuse;
                button3.Text = "A5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "A4")
            {
                this.BackColor = Color.Red;
                button4.Text = plaka;
            }
            else
            {
                button4.BackColor = Color.Chartreuse;
                button4.Text = "A4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "A3")
            {
                this.BackColor = Color.Red;
                button5.Text = plaka;
            }
            else
            {
                button5.BackColor = Color.Chartreuse;
                button5.Text = "A3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "A2")
            {
                this.BackColor = Color.Red;
                button6.Text = plaka;
            }
            else
            {
                button6.BackColor = Color.Chartreuse;
                button6.Text = "A2";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "D1")
            {
                button22.BackColor = Color.Red;
                button22.Text = plaka;
            }
            else
            {
                button22.BackColor = Color.Chartreuse;
                button22.Text = "D1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "B5")
            {
                this.BackColor = Color.Red;
                button8.Text = plaka;
            }
            else
            {
                button8.BackColor = Color.Chartreuse;
                button8.Text = "B5";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
                if (bulunduguYer == "B4")
                {
                    this.BackColor = Color.Red;
                    button9.Text = plaka;
                }
                else
                {
                    button9.BackColor = Color.Chartreuse;
                    button9.Text = "B4";
                }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "B3")
            {
                this.BackColor = Color.Red;
                button10.Text = plaka;
            }
            else
            {
                button10.BackColor = Color.Chartreuse;
                button10.Text = "B3";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "B2")
            {
                this.BackColor = Color.Red;
                button11.Text = plaka;
            }
            else
            {
                button11.BackColor = Color.Chartreuse;
                button11.Text = "B2";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "B1")
            {
                this.BackColor = Color.Red;
                button12.Text = plaka;
            }
            else
            {
                button12.BackColor = Color.Chartreuse;
                button12.Text = "B1";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "C5")
            {
                this.BackColor = Color.Red;
                button13.Text = plaka;
            }
            else
            {
                button13.BackColor = Color.Chartreuse;
                button13.Text = "C5";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "C4")
            {
                this.BackColor = Color.Red;
                button14.Text = plaka;
            }
            else
            {
                button14.BackColor = Color.Chartreuse;
                button14.Text = "C4";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "C3")
            {
                this.BackColor = Color.Red;
                button15.Text = plaka;
            }
            else
            {
                button15.BackColor = Color.Chartreuse;
                button15.Text = "C3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "C2")
            {
                this.BackColor = Color.Red;
                button16.Text = plaka;
            }
            else
            {
                button16.BackColor = Color.Chartreuse;
                button16.Text = "C2";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "C1")
            {
                this.BackColor = Color.Red;
                button17.Text = plaka;
            }
            else
            {
                button17.BackColor = Color.Chartreuse;
                button17.Text = "C1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "D5")
            {
                this.BackColor = Color.Red;
                button18.Text = plaka;
            }
            else
            {
                button18.BackColor = Color.Chartreuse;
                button18.Text = "D5";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "D4")
            {
                this.BackColor = Color.Red;
                button3.Text = plaka;
            }
            else
            {
                button19.BackColor = Color.Chartreuse;
                button19.Text = "D4";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "D3")
            {
                this.BackColor = Color.Red;
                button20.Text = plaka;
            }
            else
            {
                button20.BackColor = Color.Chartreuse;
                button20.Text = "D3";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "D2")
            {
                this.BackColor = Color.Red;
                button21.Text = plaka;
            }
            else
            {
                button21.BackColor = Color.Chartreuse;
                button21.Text = "D2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bulunduguYer == "A1")
            {
                this.BackColor = Color.Red;
                button7.Text = plaka;
            }
            else
            {
                button7.BackColor = Color.Chartreuse;
                button7.Text = "A1";
            }
        }
    }
}
