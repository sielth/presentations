using FluentAssertions;
using System;
using Xunit;

namespace Exercises
{
    public class Ex03_NumericTests
    {
        [Fact]
        public void TheAnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything_AccordingToDouglasAdams_Is42()
        {
            // Arrange
            var expected = 42;

            // Act
            int result = TheAnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void GetPrimeLargerThan2_IsOdd()
        {
            // Act
            int result = GetPrimeLargerThan2();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void DonateToScouts_Millionaire_BalanceIsPositive()
        {
            // Arrange
            var account = new BankAccount
            {
                Balance = 1_000_000
            };

            // Act
            account.DonateToScouts();

            // Assert
            throw new NotImplementedException();
        }

        [InlineData(2020)]
        [InlineData(2021)]
        [Theory]
        public void DaysInMonth_February_Either28Or29(int year)
        {
            // Act
            int result = DateTime.DaysInMonth(year, 2);

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void GetPrimarySchoolPi_DifferenceToMathPI_ApproximateByOneHundredth()
        {
            // Arrange
            double pi = Math.PI;

            // Act
            double primarySchoolPi = GetPrimarySchoolPi();

            // Assert
            throw new NotImplementedException();
        }

        #region Helpers
        private class BankAccount
        {
            public decimal Balance { get; set; }

            public void DonateToScouts() =>
                Balance -= new Random().Next(0, 100);
        }

        private static int TheAnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything() => 42;

        private static int GetPrimeLargerThan2() => 73;

        private static double GetPrimarySchoolPi() => 22 / 7d;
        #endregion
    }
}
