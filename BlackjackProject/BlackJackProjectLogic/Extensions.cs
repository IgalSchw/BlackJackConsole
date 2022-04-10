using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackProjectLogic
{
    internal static class Extensions
    {
        public static void Draw(this ICardContainer container) =>
              container.Cards.ForEach(c => c.Draw());

    }
}
