using NUnit.Framework;
using QualityMeasurementProgram;
namespace QualityMeasurementTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnsEqual()
        {
            try
            {

                Feet firstFeet = new Feet(0.0);
                Feet secondFeet = new Feet(0.0);
                Assert.AreEqual(firstFeet, secondFeet);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenStringFeetAndZeroFeet_WhenInvalidArgument_ShouldReturnsThrowException()
        {
            try
            {
                
                Feet firstFeet = new Feet("0.0");
                Feet secondFeet = new Feet(0.0);
                Assert.AreEqual(firstFeet, secondFeet);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnsNotEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(5.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = firstFeet;
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(3.0);
            Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
        }

        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(1.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }
    }
}