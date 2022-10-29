using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Form1 : Form
    {
        HeroList HeroList = new HeroList(new List<Hero>());
        public Form1(HeroList list)
        {
            InitializeComponent();
            HeroList = list;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CreateHero_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(HeroList);

            Hero hero = new Hero();

            // name
            hero.Name = txt_Name.Text;
            // add special abilities to arraylist
            List<string> list = new List<string>();
            foreach (var checkbox in groupBox1.Controls)
            {
                if (checkbox is CheckBox && ((CheckBox)checkbox).Checked)
                {
                    list.Add(((CheckBox)checkbox).Text);
                }
            }
            hero.SpecialAbilities = list;
            // hometown
            hero.Hometown = listBox1.SelectedItem.ToString();
            // relic
            foreach(var radioBtn in groupBox3.Controls)
            {
                if(((RadioButton)radioBtn).Checked)
                {
                    hero.Relic = ((RadioButton)radioBtn).Text;
                }
            }
            
            // speed
            hero.Speed = hScrollBar3.Value;
            // endurance
            hero.Endurance = hScrollBar2.Value;
            // strength
            hero.Strength = hScrollBar1.Value;
            // birthday
            hero.Birthday = dateTimePicker1.Value;
            // recieved power
            hero.RecievedPower = dateTimePicker2.Value;
            // fateful day
            hero.FatefulDay = dateTimePicker3.Value;
            // experience
            hero.Experience = numericUpDown1.Value;
            // color
            hero.Color = pictureBox1.BackColor;
            // evil
            hero.Evil = trackBar1.Value;

            HeroList.List.Add(hero);

            // form 2
            Form2 f2 = new Form2(HeroList);
            this.Hide();
            f2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                pictureBox1.BackColor = color;
            }
        }

        private void ScrollEvent_Potential(object sender, EventArgs e)
        {
            lbl_potential.Text = trackBar1.Value.ToString();
        }

        private void ScrollEvent_Speed(object sender, ScrollEventArgs e)
        {
            if(hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value > 100)
            {
                hScrollBar1.Value = (100 - hScrollBar3.Value) / 2;
                hScrollBar2.Value = (100 - hScrollBar3.Value) / 2;
            }

            lbl_speed.Text = hScrollBar3.Value.ToString();
            lbl_endurance.Text = hScrollBar2.Value.ToString();
            lbl_strength.Text = hScrollBar1.Value.ToString();
        }

        private void ScrollEvent_Endurance(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value > 100)
            {
                hScrollBar1.Value = (100 - hScrollBar2.Value) / 2;
                hScrollBar3.Value = (100 - hScrollBar2.Value) / 2;
            }

            lbl_speed.Text = hScrollBar3.Value.ToString();
            lbl_endurance.Text = hScrollBar2.Value.ToString();
            lbl_strength.Text = hScrollBar1.Value.ToString();
        }

        private void ScrollEvent_Strength(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value > 100)
            {
                hScrollBar3.Value = (100 - hScrollBar1.Value) / 2;
                hScrollBar2.Value = (100 - hScrollBar1.Value) / 2;
            }

            lbl_speed.Text = hScrollBar3.Value.ToString();
            lbl_endurance.Text = hScrollBar2.Value.ToString();
            lbl_strength.Text = hScrollBar1.Value.ToString();
        }
    }
}
