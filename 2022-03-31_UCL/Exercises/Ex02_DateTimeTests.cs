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
        public void In_2022_Easter_Sunday_Falls_On_April_17th()
        {
            // Arrange
            var expected = 17.April(2022);

            // Act
            DateTime date = EasterSunday();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void The_start_of_this_presentation_is_within_5_minutes_of_the_scheduled_time()
        {
            // Arrange
            var expectedStartOfLecture = 31.March(2022).At(09.Hours());

            // Act
            DateTime date = StartOfThisPresentation();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void In_2022_Danish_daylight_saving_time_ends_30st_of_October_at_0300_GMT_Plus2()
        {
            // Express expectedEndOfDst using the Fluent API from FluentAssertions.Extensions
            // See https://fluentassertions.com/datetimespans/ for examples

            // Arrange
            DateTimeOffset expectedEndOfDst = default;

            // Act
            DateTimeOffset date = DaylightSavingTimeEnd();

            // Assert
            date.Should().Be(expectedEndOfDst);
        }

        #region Helpers
        private static DateTime EasterSunday() => new(2022, 04, 17);

        private static DateTime StartOfThisPresentation() => new DateTime(2022, 03, 31, 09, 00, 00).AddMinutes(new Random().Next(-5, 5));

        private static DateTimeOffset DaylightSavingTimeEnd() => new(2022, 10, 30, 03, 00, 00, TimeSpan.FromHours(2));
        #endregion
    }
}
