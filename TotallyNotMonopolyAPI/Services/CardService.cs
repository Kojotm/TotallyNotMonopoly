using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;

namespace Services
{
    public interface ICardService
    {
        Fortune GetRandomFortuneCard();
        Chance GetRandomChanceCard();
    }

    public class CardService : ICardService
    {
        private readonly GameTableContext context;

        public CardService(GameTableContext context)
        {
            this.context = context;
        }

        public Fortune GetRandomFortuneCard()
        {
            var cards = context.FortuneCards.ToListAsync();
            var rand = new Random();

            return cards.Result[rand.Next(0, cards.Result.Count)];
        }

        public Chance GetRandomChanceCard()
        {
            var cards = context.ChanceCards.ToListAsync();
            var rand = new Random();

            return cards.Result[rand.Next(0, cards.Result.Count)];
        }
    }
}
