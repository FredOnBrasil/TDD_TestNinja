using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// testing at this time an method who return null;
    /// </summary>
    [TestFixture]
    class ErrorLoggerTests
    {
        //private field from errorLogger class to initialize and make code more clean
        private ErrorLogger _errorLogger;

        //SetUp --make code most clean
        //TearDown --used in Integration Tests

        /// <summary>
        /// SetUp is Used to initialize the class inside every test, and helps to make code most clean
        /// </summary>
        [SetUp]
        public void Setup()
        {
            //to initialize the class math every time a new test is called
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCall_SetTheLastErrorProperty()
        {
            //Act
            _errorLogger.Log("a");

            //Assert
            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //Assert --- using lambda expressions and delegates to test the method
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }

        /// <summary>
        /// Test used to WPF and Xamarin Apps !!! in other words: this tests methods who raises events
        /// </summary>
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            //Act
            ///---explanation: event = _errorLogger.ErrorLogged
            ///---using a new handler = +=
            ///---lambda expression = "(sender, args) => " onto this sender = source og the event / args = event arguments
            ///---body of this function = { id = args; }
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, args) => { id = args; };
            _errorLogger.Log("a");

            //Assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
