using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        /// <summary>
        /// Refactoring the code:
        /// </summary>
        private CustomerController _controller;

        [SetUp]
        public void setup()
        {
            //to initialize the class every time a new test is called
            _controller = new CustomerController();
        }

        /// <summary>
        /// test the type of return_type in one method
        /// </summary>
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            //Act
            var result = _controller.GetCustomer(0);
            
            //Assert(way1: NotFound)
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //Assert(way2: NotFound and one of its derivatives)
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            //Act
            var result = _controller.GetCustomer(1);
            
            //Assert
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}