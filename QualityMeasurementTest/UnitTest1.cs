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
            try
            {
                Feet firstFeet = new Feet(0.0);
                Feet secondFeet = firstFeet;
                bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
                Assert.IsTrue(areEqual);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                Feet firstFeet = new Feet(0.0);
                Feet secondFeet = new Feet(3.0);
                Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                Feet firstFeet = new Feet(0.0);
                Feet secondFeet = new Feet(1.0);
                Assert.AreNotEqual(firstFeet, secondFeet);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0InchAnd0Inch_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                Inch firstInch = new Inch(0.0);
                Inch secondInch = new Inch(0.0);
                Assert.AreEqual(firstInch, secondInch);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0InchAnd0Inch_WhenInvaluedArgument_ShouldReturnEqual()
        {
            try
            {
                Inch firstInch = new Inch("0.0");
                Inch secondInch = new Inch(0.0);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroInchAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                Inch firstInch = new Inch(0.0);
                Inch secondInch = null;
                Assert.AreNotEqual(firstInch, secondInch);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Inch firstInch = new Inch(0.0);
                Inch secondInch = new Inch(0.0);
                bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
                Assert.IsFalse(areEqual);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Inch firstInch = new Inch(0.0);
                Inch secondInch = firstInch;
                bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
                Assert.IsTrue(areEqual);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}