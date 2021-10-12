using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Property
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Player Owner { get; set; }
        public int house { get; set; }
        public int cost { get; set; }
        public int[] rent { get; set; }
    }
}
