using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Activity4
{
    public partial class Form2 : Form
    {
        HeroList List;
        public Form2(HeroList list)
        {
            InitializeComponent();
            List = list;
        }

        private void Form2_LoadEvent(object sender, EventArgs e)
        {
            foreach(var item in List.List)
            {
                hero_List.Items.Add(item.Name);
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1(List);
            form1.Show();
        }

        private void hero_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = List.List[hero_List.SelectedIndex].ToString();
        }
    }
}
