using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        /// <summary>
        /// Testing Strings !!!
        /// </summary>
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            //Arrange
            var formatter = new  HtmlFormatter();
            
            //Act
            var result = formatter.FormatAsBold("abc");
            
            //Assert(--specific assertion) obs: ignore case used to ignore case sensitive comparison
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            //Assert(--more general assertion)
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);
        }
        
    }
}