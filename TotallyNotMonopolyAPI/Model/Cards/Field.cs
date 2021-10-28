using System.Collections.Generic;

namespace Model.Cards
{
    public enum Colors
    {
        Brown,
        LightBlue,
        Magenta,
        Orange,
        Red,
        Yellow,
        Green,
        DarkBlue,
        None
    }

    public enum Types
    {
        Chance,
        CommunityChest,
        Transport,
        Property,
        Penalty,
        Corner,
        Utility
    }

    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Colors Color { get; set; }
        public string Image { get; set; }

        // This must be paid when stepped on the field
        public string Rent { get; set; }

        // Purchase value
        public int Value { get; set; }

        public int Level { get; set; }
        public int UpgradeCost { get; set; }
        public int Col { get; set; }
        public int Row { get; set; }
        public Types Type { get; set; }

        // This number indicates which game table's field is this card
        public int SetNumber { get; set; }
    }
}
