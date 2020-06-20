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

    }
}