using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4
{
    public class HeroList
    {
        public List<Hero> List { get; set; }

        public HeroList(List<Hero> list)
        {
            List = list;
        }
    }
}
