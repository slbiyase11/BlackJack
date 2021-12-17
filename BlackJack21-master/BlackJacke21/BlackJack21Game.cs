using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJacke21
{
    public class BlackJack21Game
    {
        public string PlayBlackJack(List<string> cardInput)
        {
            var result = string.Empty;

            var getDealersCardsValue = GetDealerCardsInHandValue();

            var playerCardValue = GetSumOfPlayersCardsInHand(cardInput);

            var hasAce = DoesPlayersCardListHaveAces(cardInput);


            if ((cardInput.Count() >= 5 && playerCardValue < 21) || (playerCardValue < 21 && playerCardValue > getDealersCardsValue) )
            {
                result = "Player Won";
            }
            else {

                if (playerCardValue > 21 && hasAce)
                {
                    if (hasAce == true)
                    {
                        playerCardValue = (playerCardValue - 11) + 1;
                    }

                    if (playerCardValue >= getDealersCardsValue)
                    {
                        if (playerCardValue <= 21 || playerCardValue == getDealersCardsValue)
                        {
                            result = "Player Won";
                        }
                        else
                        {
                            result = "Dealer Won";
                        }
                    }
                    else
                    {
                        result = "Dealer Won";
                    }
                }
                else
                {
                    result = "Dealer Won";
                }
            }

            return result;
        }

        private bool DoesPlayersCardListHaveAces(List<string> cardInput)
        {
            if (cardInput.Any(str => str.Contains("Ace")))
            {
                return true;
            }
            return false;
        }

        public int GetDealerCardsInHandValue()
        {
            var cardInput = new List<string>() { "Jack of Spades", "Nine of Hearts" };
            return GetSumOfPlayersCardsInHand(cardInput);
        }

        public int GetSumOfPlayersCardsInHand(List<string> cardInput)
        {
            var sum = 0;

            foreach (var card in cardInput)
            {
                var cardValue = GetCardValue(card);
                sum = sum + cardValue;
            }

            return sum;
        }

        

        private int GetCardValue(string card)
        {
            var cardName = card.Substring(0, card.IndexOf(" ")).ToLower();
            var cardValue = 0;

            switch (cardName)
            {
                case "ace":
                    cardValue = 11;
                    break;

                case "jack":
                    cardValue = 10;
                    break;

                case "queen":
                    cardValue = 10;
                    break;

                case "king":
                    cardValue = 10;
                    break;

                case "nine":
                    cardValue = 9;
                    break;

                case "eight":
                    cardValue = 8;
                    break;

                case "seven":
                    cardValue = 7;
                    break;

                case "six":
                    cardValue = 6;
                    break;

                case "five":
                    cardValue = 5;
                    break;

                case "four":
                    cardValue = 4;
                    break;

                case "three":
                    cardValue = 3;
                    break;

                case "two":
                    cardValue = 2;
                    break;

                case "one":
                    cardValue = 1;
                    break;

                default:
                    cardValue = 0;
                    break;
            }

            return cardValue;
        }
    }
}
