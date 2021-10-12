using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; } = 1500;
        public List<Property> properties { get; set; }
    }
}
