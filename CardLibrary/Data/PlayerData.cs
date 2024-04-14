using System;
using System.Collections.Generic;
using Unity.Quana.CardEngine.Types;

namespace Unity.Quana.CardEngine.Data
{
    [Serializable]
    public class PlayerData
    {
        public string Name = "";
        public string UserId = "";
        public List<Card> CardsInHand = new(); //Cards in the player's hand
        public List<ActionHistory> History = new(); //History of actions performed by the player
        private readonly int _playerIndex;

        public PlayerData(int index)
        {
            _playerIndex = index;
        }


        [Serializable]
        public class ActionHistory
        {
        }
    }
}