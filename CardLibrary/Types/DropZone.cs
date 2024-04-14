using System.Collections.Generic;

namespace Unity.Quana.CardEngine.Types
{
    public class DropZone
    {
        public readonly List<Card> Cards = new();

        public List<Card> GetCardsFromZone()
        {
            return Cards;
        }
    }
}