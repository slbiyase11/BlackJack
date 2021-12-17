using BlackJacke21;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BlackJacke21Tests
{
    [TestFixture]
    public class BlackJack21GameTests
    {
        [Test]
        public void when_given_cards_return_sum()
        {
            // Arrange
            var cardInput = new List<string>() { "Jack of Spades", "Nine of Hearts" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.GetSumOfPlayersCardsInHand(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo(19));
        }


        [Test]
        public void when_given_dealercards_return_sum_of_DealerCards_in_hand()
        {
            // Arrange
            // Act
            var sut = new BlackJack21Game();
            int result = sut.GetDealerCardsInHandValue();

            // Assert
            Assert.That(result, Is.EqualTo(19));
        }

        [Test]
        public void when_player_places_seven_of_hearts_seven_of_diamonds_seven_of_clubs_six_of_spades_return_dealer_won()
        {
            // Arrange
            var cardInput = new List<string>() { "Seven Of Spades", "Seven of Hearts", "Seven of Diamonds", "Six of Spades" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Dealer Won"));
        }


        [Test]
        public void when_player_places_ace_of_hearts_seven_of_diamonds_seven_of_clubs_six_of_spades_return_player_won()
        {
            // Arrange
            var cardInput = new List<string>() { "Ace Of Spades", "Seven of Hearts", "Seven of Diamonds", "Six of Spades" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Player Won"));
        }

        [Test]
        public void when_player_places_ace_of_hearts_seven_of_diamonds_seven_of_clubs_five_of_spades_return_player_won()
        {
            // Arrange
            var cardInput = new List<string>() { "Ace Of Spades", "Seven of Hearts", "Seven of Diamonds", "five of Spades" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Player Won"));
        }


        [Test]
        public void when_player_places_an_ace_six_of_hearts_ace_of_diamonds_return_dealer_won()
        {
            // Arrange
            var cardInput = new List<string>() { "Ace Of Spades", "Six of Hearts", "Ace of Diamonds"};

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Dealer Won"));
        }

        [Test]
        public void when_player_places_an_ace_seven_of_hearts_ace_of_diamonds_return_player_won()
        {
            // Arrange
            var cardInput = new List<string>() { "Ace Of Spades", "Seven of Hearts", "Ace of Diamonds" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Player Won"));
        }


        [Test]
        public void when_player_andrew_places_diamonds_return_dealer_won()
        {
            // Arrange
            var cardInput = new List<string>() { "King Of Diamonds", "Four Of Spades", "Four of Clubs" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Dealer Won"));
        }


        [Test]
        public void when_player_carl_places_queen_six_nine_diamonds_return_dealer_won()
        {
            // Arrange
            var cardInput = new List<string>() { "Queen of Clubs", "Six Of Spades", "Nine of Diamonds" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.That(result, Is.EqualTo("Dealer Won"));
        }


        [Test]
        public void when_player_bill_places_5_cards_and_less_than_twenty_one_player_wins()
        {
            // Arrange
            var cardInput = new List<string>() { "Two of Spades", "Two Of Diamonds", "Two of Hearts", "Four of Diamonds", "Five of Clubs" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.AreEqual("Player Won", result);
        }

        [Test]
        public void when_player_cards_is_less_than_twenty_one_but_greater_than_dealer_cards_player_wins()
        {
            // Arrange
            var cardInput = new List<string>() { "King of Spades", "Nine Of Diamonds", "One of Hearts" };

            // Act
            var sut = new BlackJack21Game();
            var result = sut.PlayBlackJack(cardInput);

            // Assert
            Assert.AreEqual("Player Won", result);
        }


    }
}
