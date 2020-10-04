using System;
using FluentAssertions;
using Xunit;

namespace Exercises
{
    public class Ex04_StringTests
    {
        [Fact]
        public void GetStarSign_DefaultPerson_IsNotEmpty()
        {
            // Arrange
            var person = new Person();

            // Act
            string starSign = person.GetStarSign();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void ThisTestFramework_IgnoringCasing_IsXunit()
        {
            // Arrange
            string expectedFrameworkName = "xunit";

            // Act
            string frameworkName = GetTestFramework();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void GetNephewsOfDonaldDuck_ContainLouie()
        {
            // Arrange
            string expectedNephew = "Louie";

            // Act
            string[] nephews = GetNephewsOfDonaldDuck();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void GetDanishAlphabeth_Have29Letters()
        {
            // Arrange
            int expectedLength = 29;

            // Act
            string alphabet = GetDanishAlphabeth();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void GetErrorMessage_ContainFooAndBarInThatOrder()
        {
            // Act
            string errorMessage = GetErrorMessage();

            // Assert
            throw new NotImplementedException();
        }

        #region Helpers
        private class Person
        {
            public string GetStarSign() => "Taurus";
        }

        public static string GetTestFramework() => "xUniT";

        public static string[] GetNephewsOfDonaldDuck() => new[] { "Huey", "Louie", "Dewey" };

        public static string GetDanishAlphabeth() => "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";

        public static string GetErrorMessage() => "Yada Yada Foo Yada Yada Bar Yada Yada";
        #endregion
    }
}
