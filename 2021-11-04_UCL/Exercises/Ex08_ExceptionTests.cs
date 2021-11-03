using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace Exercises
{
    public class Ex08_ExceptionTests
    {
        [Fact]
        public void DoesThrow_WrappedInAction_ThrowInvalidOperationException()
        {
            // Arrange
            var subject = new Thrower();

            // Act
            Action act = () => subject.DoesThrow();

            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        public void DoesThrow_ThrowInvalidOperationAdvanced()
        {
            // *  Throw InvalidOperationException,
            //  * which exception message contains "foobar"
            // * the InvalidOperationException has an InnerException, 
            //  * which is exactly DivideByZeroException,
            //  * which exception message contains "Dark Side"

            // Arrange
            var subject = new Thrower();

            // Act
            Action act = () => subject.DoesThrow();

            // Assert
            throw new NotImplementedException();
        }

        #region Helpers
        private class Thrower
        {
            public void DoesThrow() =>
                throw new InvalidOperationException("Yada Yada foobar Yada Yada",
                    new DivideByZeroException("Something, Something, Something, Dark Side"));

            public int DoesNotThrow() => 42;

            public Task DoesThrowAsync()
            {
                DoesThrow();
                return Task.CompletedTask;
            }

            public Task<int> DoesNotThrowAsync() => Task.FromResult(DoesNotThrow());
        }
        #endregion
    }
}
