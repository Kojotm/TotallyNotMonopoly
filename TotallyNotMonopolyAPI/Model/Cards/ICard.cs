using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cards
{
    public interface ICard
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Action();
    }
}
