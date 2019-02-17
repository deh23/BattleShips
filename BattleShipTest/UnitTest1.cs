using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using battleShipsConsole;
using Moq;
using System.Collections.Generic;
using System.Dynamic;

namespace BattleShipTest
{
    [TestClass]
    public class RequirementTests
    {
        [TestMethod]
        public void WinnableTest()
        {
            var moqGame = new Mock<GameLogic>();
            moqGame.Setup(m => m.SetupMap()).Returns("winner");

            Assert.AreEqual(moqGame.Object.SetupMap(), "winner");
        }
        [TestMethod]
        public void CreatesShipsTest()
        {
            var moqGame = new Player("User");
            Player player = new Player("User");
            player.IsWinner = false;
            player.Name = "User";
            player.Ships = new List<Ship>();

            dynamic BattleShip = new BattleShip();
            BattleShip.Name = "BattleShip";
            BattleShip.Length = 5;
            BattleShip.ShipType = ShipType.BattleShip;
            BattleShip.Hits = 0;
            BattleShip.IsSunk = false;

            dynamic Destroyer = new Destroyer();
            Destroyer.Name = "Destroyer";
            Destroyer.Length = 4;
            Destroyer.ShipType = ShipType.Destroyer;
            Destroyer.Hits = 0;
            Destroyer.IsSunk = false;

            player.Ships.Add(BattleShip);
            player.Ships.Add(Destroyer);
            player.Ships.Add(Destroyer);
            Assert.AreEqual(moqGame, player);
        }
        [TestMethod]
        public void Test()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void AreAllShipsSunkTest()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void LegnthOfBattleShipTest()
        {
            Assert.Fail();
        }
    }
}
