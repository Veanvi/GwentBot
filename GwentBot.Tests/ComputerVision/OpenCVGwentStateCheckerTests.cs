﻿// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using GwentBot.ComputerVision;
using GwentBot.StateAbstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Drawing;

namespace GwentBot.Tests.ComputerVision
{
    [TestClass]
    public class OpenCvGwentStateCheckerTests
    {
        #region GameSessionStates Checks

        [TestMethod]
        public void GetCurrentGameSessionStates_WinAlertSrc_IdentifierWinAlert()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GameSessionStates\WinAlertSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.WinAlert, result);
        }

        [TestMethod]
        public void GetCurrentGameSessionStates_LosingAlertSrc_IdentifierLosingAlert()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GameSessionStates\LosingAlertSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.LosingAlert, result);
        }

        [DataTestMethod]
        [DataRow(@"ComputerVision\GameSessionStates\MulliganSrc-MonsterTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\MulliganSrc-NilfgaardTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\MulliganSrc-SkelligeTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\MulliganSrc-NorthTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\MulliganSrc-ScoiataelTable.png")]
        public void GetCurrentGameSessionStates_MulliganSrc_IdentifierMulligan(string srcImgPath)
        {
            //arrage
            var gameScreenshotPath = srcImgPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.Mulligan, result);
        }

        [DataTestMethod]
        [DataRow(@"ComputerVision\GameSessionStates\OpponentChangesCardsSrc-MonsterTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\OpponentChangesCardsSrc-NilfgaardTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\OpponentChangesCardsSrc-NorthTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\OpponentChangesCardsSrc-ScoiataelTable.png")]
        [DataRow(@"ComputerVision\GameSessionStates\OpponentChangesCardsSrc-SkelligeTable.png")]
        public void GetCurrentGameSessionStates_OpponentChangesCardsSrc_IdentifierOpponentChangesCards(string srcImgPath)
        {
            //arrage
            var gameScreenshotPath = srcImgPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.OpponentChangesCards, result);
        }

        [TestMethod]
        public void GetCurrentGameSessionStates_MyTurnPlaySrc_IdentifierMyTurnPlay()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GameSessionStates\MyTurnPlaySrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.MyTurnPlay, result);
        }

        [TestMethod]
        public void GetCurrentGameSessionStates_EnemyTurnPlaySrc_IdentifierEnemyTurnPlay()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GameSessionStates\EnemyTurnPlaySrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.EnemyTurnPlay, result);
        }

        [TestMethod]
        public void GetCurrentGameSessionStates_UnknownSrc_IdentifierUnknown()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\TestSrcImg\AlwaysUnknownSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.Unknown, result);
        }

        [TestMethod]
        public void GetCurrentGameSessionStates_MatchResultsScreenSrc_IdentifierMatchResultsScreen()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GameSessionStates\MatchResultsScreenSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.MatchResultsScreen, result);
        }

        [TestMethod]
        public void GetCurrentGameSessionStates_MatchRewardsScreenSrc_IdentifieraMatchRewardsScreen()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GameSessionStates\MatchRewardsScreenSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGameSessionStates();

            //assert
            Assert.AreEqual(GameSessionStates.MatchRewardsScreen, result);
        }

        #endregion GameSessionStates Checks

        #region CoinTossStates Checks

        [TestMethod]
        public void GetCurrentCoinTossStates_StartTossSrc_IdentifierStartToss()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\CoinTossStates\StartTossSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentCoinTossStates();

            //assert
            Assert.AreEqual(CoinTossStates.StartToss, result);
        }

        [TestMethod]
        public void GetCurrentCoinTossStates_СoinWonSrc_IdentifierСoinWon()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\CoinTossStates\СoinWonSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentCoinTossStates();

            //assert
            Assert.AreEqual(CoinTossStates.CoinWon, result);
        }

        [TestMethod]
        public void GetCurrentCoinTossStates_CoinLostSrc_IdentifierCoinLost()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\CoinTossStates\CoinLostSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentCoinTossStates();

            //assert
            Assert.AreEqual(CoinTossStates.CoinLost, result);
        }

        [TestMethod]
        public void GetCurrentCoinTossStates_UnknownSrc_IdentifierUnknown()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\TestSrcImg\AlwaysUnknownSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentCoinTossStates();

            //assert
            Assert.AreEqual(CoinTossStates.Unknown, result);
        }

        #endregion CoinTossStates Checks

        #region GlobalGameStates Checks

        [TestMethod]
        public void GetCurrentGlobalGameStates_ArenaModeTabSrc_IdentifierArenaModeTab()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GlobalGameStates\ArenaModeTabSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGlobalGameStates();

            //assert
            Assert.AreEqual(GlobalGameStates.ArenaModeTab, result);
        }

        [DataTestMethod]
        [DataRow(@"ComputerVision\GlobalGameStates\GameModesTabSrc.png")]
        [DataRow(@"ComputerVision\GameModesTab\MonsterTableSrc.png")]
        [DataRow(@"ComputerVision\GameModesTab\NilfgaardTable.png")]
        [DataRow(@"ComputerVision\GameModesTab\NorthTableSrc.png")]
        [DataRow(@"ComputerVision\GameModesTab\ScoiataelTable.png")]
        [DataRow(@"ComputerVision\GameModesTab\SkelligeTable.png")]
        public void GetCurrentGlobalGameStates_GameModesTabSrc_IdentifierGameModesTab(string srcPath)
        {
            //arrage
            var gameScreenshotPath = srcPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGlobalGameStates();

            //assert
            Assert.AreEqual(GlobalGameStates.GameModesTab, result);
        }

        [DataTestMethod]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\MonsterTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\NilfgaardTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\NorthTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\ScoiataelTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\SkelligeTable.png")]
        public void GetCurrentGlobalGameStates_FriendlyGameStartStatesSrc_IdentifierUnknown(string srcPath)
        {
            //arrage
            var gameScreenshotPath = srcPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGlobalGameStates();

            //assert
            Assert.AreEqual(GlobalGameStates.Unknown, result);
        }

        [TestMethod]
        public void GetCurrentGlobalGameStates_HeavyLoadingSrc_IdentifierHeavyLoading()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GlobalGameStates\HeavyLoadingSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGlobalGameStates();

            //assert
            Assert.AreEqual(GlobalGameStates.HeavyLoading, result);
        }

        [TestMethod]
        public void GetCurrentGlobalGameStates_MainMenuSrc_IdentifierMainMenu()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\GlobalGameStates\MainMenuSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGlobalGameStates();

            //assert
            Assert.AreEqual(GlobalGameStates.MainMenu, result);
        }

        [TestMethod]
        public void GetCurrentGlobalGameStates_UnknownSrc_IdentifierUnknown()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\TestSrcImg\AlwaysUnknownSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentGlobalGameStates();

            //assert
            Assert.AreEqual(GlobalGameStates.Unknown, result);
        }

        #endregion GlobalGameStates Checks

        #region StartGameStates Checks

        [TestMethod]
        public void GetCurrentStartGameStates_GameLoadingScreenSrc_IdentifierGameLoadingScreen()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\StartGameStates\GameLoadingScreen.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentStartGameStates();

            //assert
            Assert.AreEqual(StartGameStates.GameLoadingScreen, result);
        }

        [TestMethod]
        public void GetCurrentStartGameStates_UnknownSrc_IdentifierUnknown()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\TestSrcImg\AlwaysUnknownSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentStartGameStates();

            //assert
            Assert.AreEqual(StartGameStates.Unknown, result);
        }

        [TestMethod]
        public void GetCurrentStartGameStates_WelcomeScreenSrc_IdentifierWelcomeScreen()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\StartGameStates\WelcomeScreen.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentStartGameStates();

            //assert
            Assert.AreEqual(StartGameStates.WelcomeScreen, result);
        }

        #endregion StartGameStates Checks

        #region FriendlyGameStartStates Checks

        [DataTestMethod]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\LoadingMatchSettingsSrc\MonsterTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\LoadingMatchSettingsSrc\NilfgaardTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\LoadingMatchSettingsSrc\NorthTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\LoadingMatchSettingsSrc\ScoiataelTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\LoadingMatchSettingsSrc\SkelligeTable.png")]
        public void GetCurrentFriendlyGameStartStates_LoadingMatchSettingsSrc_IdentifierLoadingMatchSettings(string srcPath)
        {
            //arrage
            var gameScreenshotPath = srcPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentFriendlyGameStartStates();

            //assert
            Assert.AreEqual(FriendlyGameStartStates.LoadingMatchSettings, result);
        }

        [DataTestMethod]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\MonsterTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\NilfgaardTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\NorthTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\ScoiataelTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\MatchSettings\SkelligeTable.png")]
        public void GetCurrentFriendlyGameStartStates_MatchSettingsSrc_IdentifierMatchSettings(string srcPath)
        {
            //arrage
            var gameScreenshotPath = srcPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentFriendlyGameStartStates();

            //assert
            Assert.AreEqual(FriendlyGameStartStates.MatchSettings, result);
        }

        [TestMethod]
        public void GetCurrentFriendlyGameStartStates_UnknownSrc_IdentifierUnknown()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\TestSrcImg\AlwaysUnknownSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentFriendlyGameStartStates();

            //assert
            Assert.AreEqual(FriendlyGameStartStates.Unknown, result);
        }

        [DataTestMethod]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\WaitingReadinessOpponentSrc\MonsterTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\WaitingReadinessOpponentSrc\NilfgaardTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\WaitingReadinessOpponentSrc\NorthTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\WaitingReadinessOpponentSrc\ScoiataelTable.png")]
        [DataRow(@"ComputerVision\FriendlyGameStartStates\WaitingReadinessOpponentSrc\SkelligeTable.png")]
        public void GetCurrentFriendlyGameStartStates_WaitingReadinessOpponentSrc_IdentifierWaitingReadinessOpponent(string strPath)
        {
            //arrage
            var gameScreenshotPath = strPath;
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentFriendlyGameStartStates();

            //assert
            Assert.AreEqual(FriendlyGameStartStates.WaitingReadinessOpponent, result);
        }

        #endregion FriendlyGameStartStates Checks

        #region Support Test Method

        private OpenCvGwentStateChecker CreationOpenCvGwentStateChecker(string gameScreenshot)
        {
            var shotCreatorMock = new Mock<IWindowScreenShotCreator>();
            shotCreatorMock.Setup(o => o.IsGameWindowFullVisible()).Returns(true);
            shotCreatorMock.Setup(o => o.GetGameScreenshot()).Returns(
                new Bitmap(gameScreenshot));

            return new OpenCvGwentStateChecker(shotCreatorMock.Object);
        }

        #endregion Support Test Method

        #region Notifications Ckecks

        [TestMethod]
        public void GetCurrentNotifications_RewardsTabSrc_IdentifierRewardsTab()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\Notifications\RewardsTabSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentNotifications();

            //assert
            Assert.AreEqual(Notifications.RewardsTab, result);
        }

        [TestMethod]
        public void GetCurrentNotifications_ReceivedRewardSrc_IdentifierReceivedReward()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\Notifications\ReceivedRewardSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentNotifications();

            //assert
            Assert.AreEqual(Notifications.ReceivedReward, result);
        }

        [TestMethod]
        public void GetCurrentNotifications_FriendlyDuelSrc_IdentifierFriendlyDuel()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\Notifications\FriendlyDuelSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentNotifications();

            //assert
            Assert.AreEqual(Notifications.FriendlyDuel, result);
        }

        [TestMethod]
        public void GetCurrentNotifications_UnknownSrc_IdentifierNoNotifications()
        {
            //arrage
            var gameScreenshotPath = @"ComputerVision\TestSrcImg\AlwaysUnknownSrc.png";
            var stateChecker = CreationOpenCvGwentStateChecker(gameScreenshotPath);

            //act
            var result = stateChecker.GetCurrentNotifications();

            //assert
            Assert.AreEqual(Notifications.NoNotifications, result);
        }

        #endregion Notifications Ckecks
    }
}