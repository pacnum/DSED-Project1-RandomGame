using System;
using System.Security.Cryptography.X509Certificates;
using DSED_Project1_RandomGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testRandomDiceRoll
{
    [TestClass]
    public class UnitTest1
    {
        readonly Data myData = new Data();

        [TestMethod]
        public void IsDiceRollRandom()
        {
            myData.RNDGenerator();

            var Actual = myData.Dice;
            Assert.IsTrue(Actual > 0 && Actual < 7);

            //Commented code is incorrect
            //Assert.AreEqual(Expected, Actual);
            //actual myData.Dice
            //expected > 1 && < 7


        }

        [TestMethod]
        public void IsCounterSet()
        {
            myData.Countdown();

            var Actual = myData.Counter;
            Assert.IsTrue(Actual == 5);
            Assert.AreEqual(5, Actual);
        }


    }
}
