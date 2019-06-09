﻿using System;
using GwentBot.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GwentBot.Tests.Model
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameIWonCoinPropTest_true_false()
        {
            // Arrage
            var deck = new Deck("TestDeck");
            var user = new User("TestUser");
            var game = new Game(deck, user);
            game.IWonCoin = false;

            // Act
            game.IWonCoin = true;

            // Assert
            Assert.IsFalse((bool)game.IWonCoin);
        }

        [TestMethod]
        public void PropertyInitializationTest()
        {
            // Arrage
            var deck = new Deck("TestDeck");
            var user = new User("TestUser");
            var game = new Game(deck, user);
            bool result = false;

            // Act
            result = deck.Name == game.Deck.Name &
                user.UserName == game.User.UserName;

            // Assert
            Assert.IsTrue(result);
        }
    }
}