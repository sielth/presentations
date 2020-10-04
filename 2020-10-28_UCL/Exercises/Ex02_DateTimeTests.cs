using FluentAssertions;
using FluentAssertions.Common;
using FluentAssertions.Extensions;
using System;
using Xunit;

namespace Exercises
{
    public class Ex02_DateTimeTests
    {
        [Fact]
        public void EasterSunday_In2020_FallsOnApril15th()
        {
            // Arrange
            var expected = 15.April(2020);

            // Act
            DateTime date = EasterSunday();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void StartOfThisPresentation_JonasIsGuessingTheTime_StartAtmost5MinutesBeforeOrAfter()
        {
            // Arrange
            var expectedStartOfLecture = 28.October(2020).At(09.Hours());

            // Act
            DateTime date = StartOfThisPresentation();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void RandomDayFromJuleKalender_In2020_IsBetween1stAnd24thDecember()
        {
            // Arrange
            var firstDayToOpen = 1.December(2020);
            var lastDayToOpen = 24.December(2020);

            // Act
            DateTime date = RandomDateFromJuleKalender();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void DaylightSavingTimeEnd_InDenmark2020_25thOctoberAt0300GmtPlus2()
        {
            // Express expectedEndOfDst using the Fluent API from FluentAssertions.Extensions

            // Arrange
            DateTimeOffset expectedEndOfDst = default;

            // Act
            DateTimeOffset date = DaylightSavingTimeEnd();

            // Assert
            date.Should().Be(expectedEndOfDst);
        }

        #region Helpers
        private static DateTime EasterSunday() => new DateTime(2020, 04, 15);

        private static DateTime StartOfThisPresentation() => new DateTime(2020, 10, 28, 09, 00, 00).AddMinutes(new Random().Next(-5, 5));

        private static DateTime RandomDateFromJuleKalender() => new DateTime(2020, 12, new Random().Next(01, 24));

        private static DateTimeOffset DaylightSavingTimeEnd() => new DateTimeOffset(2020, 10, 25, 03, 00, 00, TimeSpan.FromHours(2));
        #endregion
    }
}
