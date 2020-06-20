namespace QualityMeasurementTest
{
    using NUnit.Framework;
    using QualityMeasurementProgram;

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
                Length firstFeet = new Length(Length.Unit.FEET, 0.0);
                Length secondFeet = new Length(Length.Unit.FEET, 0.0);
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

                Length firstFeet = new Length(Length.Unit.FEET, "0.0");
                Length secondFeet = new Length(Length.Unit.FEET, 0.0);
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
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 5.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstFeet = new Length(Length.Unit.FEET, 0.0);
                Length secondFeet = firstFeet;
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
                Length firstFeet = new Length(Length.Unit.FEET, 0.0); ;
                Length secondFeet = new Length(Length.Unit.FEET, 3.0);
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
                Length firstFeet = new Length(Length.Unit.FEET, 0.0);
                Length secondFeet = new Length(Length.Unit.FEET, 1.0);
                Assert.AreNotEqual(firstFeet, secondFeet);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroInchAndZeroInch_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                Length firstInch = new Length(Length.Unit.INCH, 0.0);
                Length secondInch = new Length(Length.Unit.INCH, 0.0);
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
                Length firstInch = new Length(Length.Unit.INCH, "0.0");
                Length secondInch = new Length(Length.Unit.INCH, 0.0);
            }
            catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroInchAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                Length firstInch = new Length(Length.Unit.INCH, 0.0);
                Length secondInch = null;
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
                Length firstInch = new Length(Length.Unit.INCH, 0.0);
                Length secondInch = new Length(Length.Unit.INCH, 0.0);
                bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
                Assert.IsFalse(areEqual);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfInch_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstInch = new Length(Length.Unit.INCH, 0.0);
                Length secondInch = firstInch;
                bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
                Assert.IsTrue(areEqual);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                Length firstInch = new Length(Length.Unit.INCH, 0.0);
                Length secondInch = new Length(Length.Unit.INCH, 0.0);
                Assert.AreEqual(firstInch.GetType(), secondInch.GetType());
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroFeetAndZeroInch_WhenValueChecked_ShouldReturnEqualLength()
        {
            try
            {
                Length feetValue = new Length(Length.Unit.FEET, 0.0);
                Length inchValue = new Length(Length.Unit.INCH, 0.0);
                bool compareCheck = feetValue.Compare(inchValue);
                Assert.IsTrue(compareCheck);
            }catch(QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneInch_WhenValueChecked_ShouldReturnNotEqualLength()
        {
            try
            {
                Length feetValue = new Length(Length.Unit.FEET, 1.0);
                Length inchValue = new Length(Length.Unit.INCH, 2.0);
                bool compareCheck = feetValue.Compare(inchValue);
                Assert.IsFalse(compareCheck);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenOneFeetAndOneInch_WhenInvalidValueChecked_ShouldReturnThrowException()
        {
            try
            {
                Length feetValue = new Length(Length.Unit.FEET, "1.0");
                Length inchValue = new Length(Length.Unit.INCH, 2.0);
                bool compareCheck = feetValue.Compare(inchValue);
                Assert.IsFalse(compareCheck);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1InchAnd1Feet_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                Length inchValue = new Length(Length.Unit.INCH, 1.0);
                Length feetValue = new Length(Length.Unit.FEET, 2.0);
                bool compareCheck = inchValue.Compare(feetValue);
                Assert.IsFalse(compareCheck);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1FeetAnd12Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                Length feetValue = new Length(Length.Unit.FEET, 1.0);
                Length inchValue = new Length(Length.Unit.INCH, 12.0);
                bool compareCheck = feetValue.Compare(inchValue);
                Assert.IsTrue(compareCheck);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given12InchAnd1Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                Length inchValue = new Length(Length.Unit.INCH, 12.0);
                Length feetValue = new Length(Length.Unit.FEET, 1.0);
                bool compareCheck = inchValue.Compare(feetValue);
                Assert.IsTrue(compareCheck);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}