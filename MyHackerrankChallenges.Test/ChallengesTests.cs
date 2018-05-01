using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyHackerrankChallenges.Booking;
using MyHackerrankChallenges.Practice;

namespace MyHackerrankChallenges.Test
{
    [TestClass]
    public class ChallengesTests
    {
        #region BirthdayChocolate

        [TestMethod]
        public void BirthdayChocolateTest()
        {
            var bc = new BirthdayChocolate();
            var expectedResult = 2;
            var actualResult = bc.solve(5, new int[] { 1, 2, 1, 3, 2 }, 3, 2);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void BirthdayChocolateTest2()
        {
            var bc = new BirthdayChocolate();
            var expectedResult = 0;
            var actualResult = bc.solve(6, new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void BirthdayChocolateTest3()
        {
            var bc = new BirthdayChocolate();
            var expectedResult = 1;
            var actualResult = bc.solve(1, new int[] { 4 }, 4, 1);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void BirthdayChocolateTest4()
        {
            var bc = new BirthdayChocolate();
            var expectedResult = 4;
            var actualResult = bc.solve(5, new int[] { 1, 2, 1, 2, 1 }, 3, 2);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        #endregion

        #region SupportOperators

        [TestMethod]
        public void SupportOperatorsOverlaping1()
        {
            var ranges = new[]
            {
                new[] {1, 6},
                new[] {1, 5},
                new[] {2, 10},
            };
            var result = SupportOperators.OperatorsNeeded(1, ranges);
            const int expectedResult = 1;
            Assert.AreEqual(expectedResult, result);    
        }

        [TestMethod]
        public void SupportOperatorsNoOverlaping()
        {
            var ranges = new[]
            {
                new[] {7, 10},
                new[] {1, 5},
                new[] {11, 12},
            };
            var result = SupportOperators.OperatorsNeeded(0, ranges);
            const int expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        }

        #endregion
    }
}
