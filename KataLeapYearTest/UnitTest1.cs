using KataLeapYear;
using NUnit.Framework;

namespace KataLeapYearTest
{
    public class LeapYearShould
    {
        int year;
        LeapYear leapyear = new LeapYear();
        [SetUp]
        public void Setup()
        {

        }


        [TestCase(1900, false)]
        [TestCase(1996, true)]
        [TestCase(2000, true)]
        [TestCase(2001, false)]
        [TestCase(3828, true)]
        public void IsLeapTest(int date, bool result)
        {
            Assert.AreEqual(result, leapyear.IsLeap(date));
        }

        /*
        - Todo año divisible por 400 es bisiesto
        - Todo año NO divisible por 4 no es bisiesto 
        - Todo año divisible por 4 y NO por 100 es bisiesto
        - Si es divisible por 100 y no por 400 no es bisiesto
         */

        [Test]
        public void ReturnFalseIfYearIsZeroOrNegative()
        {

            //Arrange
            year = -4;
            //Act
            bool result = leapyear.IsLeap(year);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnFaseIfIsNotDivisibleByFour()
        {

            //Arrange
            year = 3;

            //Act
            bool result = leapyear.IsLeap(year);

            //Assert
            Assert.IsFalse(result);
        }


        [Test]
        public void ReturnFalseIfIsDivisibleFor100ButNotFor400()
        {

            //Arrange
            year = 2100;

            //Act
            bool result = leapyear.IsLeap(year);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test1()
        {

            //Arrange


            //Act


            //Assert
            Assert.Pass();
        }


 


    }
}