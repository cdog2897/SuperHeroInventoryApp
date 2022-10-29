using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Activity4
{
    public class Hero
    {

        public String Name { get; set; }
        public List<String> SpecialAbilities { get; set; }
        public String Hometown { get; set; }
        public String Relic { get; set; }
        public int Speed { get; set; }
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RecievedPower { get; set; }
        public DateTime FatefulDay { get; set; }
        public decimal Experience { get; set; }
        public System.Drawing.Color Color { get; set; }
        public int Evil { get; set; }


        public override String ToString()
        {
            string specAbil = "";
            foreach(var item in SpecialAbilities)
            {
                specAbil += item.ToString() + ". ";
            }

            return "" + Name + " has these powers: " + specAbil + "Hometown: " + Hometown + ". Relic: " + Relic + ". Speed: " + Speed + ". Endurace: " + Endurance + ". Strength: " + Strength + ". Birthday: " + Birthday.ToString() + ". Recieved Power: " + RecievedPower.ToString() + ". Fateful day: " + FatefulDay.ToString() + ". Years experience: " + Experience.ToString() + ". Potential to Turn Evil: " + Evil.ToString() + ". Color: " + Color.R.ToString() + Color.G.ToString() + Color.B.ToString();
        }
    }

}
