using Model;

namespace Services
{
    public class PlayerService
    {

        public Player[] CreateRandomPlayers()
        {
            Player[] players = new Player[4];

            Player player1 = new Player();
            player1.Id = 1;
            player1.Money = 1500;
            player1.Name = "Martin";

            players[0] = player1;

            Player player2 = new Player();
            player2.Id = 2;
            player2.Money = 1500;
            player2.Name = "Marcell";

            players[1] = player2;

            Player player3 = new Player();
            player1.Id = 3;
            player1.Money = 1500;
            player1.Name = "Daniel";

            players[2] = player3;

            Player player4 = new Player();
            player4.Id = 4;
            player4.Money = 1500;
            player4.Name = "Robert";

            players[3] = player4;

            return players;
        }

        public Player BuyProperty(Player player, Property property)
        {
            if (player.Money >= property.Cost)
            {
                player.Properties.Add(property);
            }
            else
            {
                return player;
            }

            return player;
        }

        public Player SellProperty(Player player, Property property)
        {
            property.Owner = null;
            player.Properties.Remove(property);
            player.Money += property.Cost;

            return player;
        }

        public Player PayRent(Player playerOwner, Player playerTenant, Property property)
        {
            // To Do
            return playerTenant;
        }

        public Player PassGo(Player player)
        {
            player.Money += 200;

            return player;
        }
    }
}
