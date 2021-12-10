using System.ComponentModel.DataAnnotations;

namespace Model.Cards
{
    public class Card
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
    }
}
