using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals; //import references to test the target class

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        //private field from math class to initialize and make code more clean
        private Math _math;

        //SetUp --make code most clean
        //TearDown --used in Integration Tests

        /// <summary>
        /// SetUp is Used to initialize the class math inside every test, and helps to make code most clean
        /// </summary>
        [SetUp]
        public void Setup()
        {
            //to initialize the class math every time a new test is called
            _math = new Math();
        }


        /// <summary>
        /// this test returns the sum of arguments, and the declaration ignore give to us the possibility to ignore
        /// the test if it is necessary 
        /// </summary>
        [Test]
        [Ignore("Because I Wanted to ! - pq eu quis ignorar !")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            ////Arrange ---before refactoring the code
            //var math = new Math();

            ////Act ---before refactoring the code
            //var result = math.Add(1, 2);

            //Act ---after refactoring the code
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        /// <summary>
        /// This is an example of parameterized method
        /// </summary>
        [Test]
        [TestCase(1,1,1)] //test case 1
        [TestCase(1,2,2)] //test case 2
        [TestCase(2,1,2)] //test case 3
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        { 
            ////Arrange ---before refactoring the code
            //var math = new Math();

            ////Act ---before refactoring the code
            //var result = math.Max(2, 1);

            //Act ---after refactoring the code
            var result = _math.Max(a,b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// Testing collections / arrays(look for Odd Numbers)
        /// </summary>
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            //Act(this populate result with odd numbers from 0 to 5, this means 1,3,5)
            var result = _math.GetOddNumbers(5);
             
            //Assert (--less specific)
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            
            //Assert (--more specific)
            Assert.That(result, Is.EquivalentTo(new [] {1,3,5}));
            
            //Assert(--specific ways)
            //Assert.That(result, Is.Ordered); // verify if its in order
            //Assert.That(result, Is.Unique); // verify if there is no repetitions
        }

        #region unusedTests
        //
        // this methods are no longer needed, because the test above perform all this tests 
        // [Test]
        // public void Max_SecondArgumentIsGreater_ReturnTheFirstArgument()
        // {
        //     ////Arrange ---before refactoring the code
        //     //var math = new Math();
        //
        //     ////Act ---before refactoring the code
        //     //var result = math.Max(2, 1);
        //
        //     //Act ---after refactoring the code
        //     var result = _math.Max(2, 1);
        //
        //     //Assert
        //     Assert.That(result, Is.EqualTo(2));
        // }
        // [Test]
        // public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        // {
        //     ////Arrange ---before refactoring the code
        //     //var math = new Math();
        //
        //     ////Act ---before refactoring the code
        //     //var result = math.Max(1, 2);
        //
        //     //Act ---after refactoring the code
        //     var result = _math.Max(1, 2);
        //
        //     //Assert
        //     Assert.That(result, Is.EqualTo(2));
        // }
        //
        // [Test]
        // public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        // {
        //     ////Arrange ---before refactoring the code
        //     //var math = new Math();
        //
        //     ////Act ---before refactoring the code
        //     //var result = math.Max(1, 1);
        //
        //     //Act ---after refactoring the code
        //     var result = _math.Max(1, 1);
        //
        //     //Assert
        //     Assert.That(result, Is.EqualTo(1));
        // }
        #endregion
    }
}
