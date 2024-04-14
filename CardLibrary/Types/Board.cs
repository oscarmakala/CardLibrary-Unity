using System.Collections.Generic;

namespace Unity.Quana.CardEngine.Types
{
    public struct Board
    {
        public List<Card> Hand;
        public Card GameCard;
        public string UserId;
    }
}