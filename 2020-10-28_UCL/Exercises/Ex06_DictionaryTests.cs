using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Exercises
{
    public class Ex06_DictionaryTests
    {
        [Fact]
        public void LeetSpeak_ShouldTranslate1337Intoleet()
        {
            // Arrange
            var expectedKey = 1337;
            var expectedValue = "leet";

            // Act
            Dictionary<int, string> leetSpeak = GetLeetSpeak();

            // Assert
            throw new NotImplementedException();
        }

        #region Helpers
        private static Dictionary<int, string> GetLeetSpeak() => new Dictionary<int, string>
        {
            [1337] = "leet"
        };
        #endregion
    }
}
