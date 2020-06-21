namespace QualityMeasurementTest
{
    using NUnit.Framework;
    using QualityMeasurementProgram;

    public class Tests
    {
        private Length yard = null;
        private Length feet = null;
        private Length inch = null;
        private Length centiMeter = null;

        [SetUp]
        public void Setup()
        {
            this.yard = new Length();
            this.feet = new Length();
            this.inch = new Length();
            this.centiMeter = new Length();
        }

        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnsEqual()
        {
            try
            {
                double firstFeet = feet.ConvertTheValue(Length.Unit.FEETToINCH, 0.0);
                double secondFeet = feet.ConvertTheValue(Length.Unit.FEETToINCH, 0.0);
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
                double secondFeet = feet.ConvertTheValue(Length.Unit.FEETToINCH, 0.0);
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
            double firstFeet = feet.ConvertTheValue(Length.Unit.FEETToINCH, 3.0);
            double firstFeet1 = feet.ConvertTheValue(Length.Unit.FEETToINCH, 5.0);
            Assert.AreNotEqual(firstFeet, firstFeet1);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstFeet = new Length();
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
                double firstFeet = feet.ConvertTheValue(Length.Unit.FEETToINCH, 3.0);
                double secondFeet = feet.ConvertTheValue(Length.Unit.YARDToINCH, 3.0);
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
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 0.0);
                double feetValue1 = feet.ConvertTheValue(Length.Unit.FEETToINCH, 1.0);
                Assert.AreNotEqual(feetValue, feetValue1);
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
                double inchValue1 = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
                Assert.AreEqual(inchValue, inchValue1);
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
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroInchAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double firstInch = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
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
                Length firstFeet = new Length();
                Length secondFeet = new Length();
                bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
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
                Length firstInch = new Length();
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
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
                double inchValue1 = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
                Assert.AreEqual(inchValue.GetType(), inchValue1.GetType());
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
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 0.0);
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
                Assert.AreEqual(inchValue, feetValue);
            }
            catch(QualityMeaurementException e)
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
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 1.0);
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
                Assert.AreNotEqual(inchValue, feetValue);
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
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
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
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 2.0);
                Assert.AreNotEqual(inchValue, feetValue);
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
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 1.0);
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 12.0);
                Assert.AreEqual(inchValue, feetValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1FeetAnd13Inch_WhenComparingLength_ShouldReturnNonEqualLength()
        {
            try
            {
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 1.0);
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 13.0);
                Assert.AreNotEqual(inchValue, feetValue);
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
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 12.0);
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 1.0);
                Assert.AreEqual(inchValue, feetValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given12InchAnd1Feet_WhenComparingLength_ShouldReturnNonEqualLength()
        {
            try
            {
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 12.0);
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 2.0);
                Assert.AreNotEqual(inchValue, feetValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnNOTEqualLength()
        {
            try
            {
                double yardValue1 = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                double yardValue2 = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                Assert.AreEqual(yardValue1, yardValue2);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenThreeFeetAndOneYard_WhenComparingLength_ShouldReturnTrue()
        {
            try
            {
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 3.0);
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                Assert.AreEqual(feetValue, yardValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenOneFeetAndOneYard_WhenCompareLength_ShouldReturnFalse()
        {
            try
            {
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 1.0);
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                Assert.AreNotEqual(feetValue, yardValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                Assert.AreNotEqual(inchValue, yardValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1YardAnd36Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 36.0);
                Assert.AreEqual(yardValue, inchValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given36InchAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double inchValue = inch.ConvertTheValue(Length.Unit.INCH, 36.0);
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                Assert.AreEqual(inchValue, yardValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1YardAnd3Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                double feetValue = feet.ConvertTheValue(Length.Unit.FEETToINCH, 3.0);
                Assert.AreEqual(feetValue, yardValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroYardAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double yardValue = yard.ConvertTheValue(Length.Unit.YARDToINCH, 1.0);
                double feetValue = feet.ConvertTheValue(Length.Unit.YARDToINCH, 3.0);
                Assert.AreNotEqual(yardValue, feetValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroCentiMeterAndZeroCentiMeter_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double firstCentiMeterValue = yard.ConvertTheValue(Length.Unit.CENTIMETER, 0.0);
                double secondCentiMeterValue = feet.ConvertTheValue(Length.Unit.CENTIMETER, 0.0);
                Assert.AreEqual(firstCentiMeterValue, secondCentiMeterValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroCentiMeterAndNull_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                double firstCentiMeterValue = yard.ConvertTheValue(Length.Unit.CENTIMETER, 0.0);
                Length secondCentiMeterValue = null;
                Assert.AreNotEqual(firstCentiMeterValue, secondCentiMeterValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Length firstCentiMeter = new Length();
                Length secondCentimeter = new Length();
                bool areEqual = System.Object.ReferenceEquals(firstCentiMeter, secondCentimeter);
                Assert.IsFalse(areEqual);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstCentiMeter = new Length();
                Length secondCentimeter = firstCentiMeter;
                bool areEqual = System.Object.ReferenceEquals(firstCentiMeter, secondCentimeter);
                Assert.IsTrue(areEqual);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double firstCentiMeter = inch.ConvertTheValue(Length.Unit.CENTIMETER, 0.0);
                double secondCentimeter = inch.ConvertTheValue(Length.Unit.CENTIMETER, 1.0);
                Assert.AreEqual(firstCentiMeter.GetType(), secondCentimeter.GetType());
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroCentiMeterAnd1CentiMeter_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstCentiMeterValue = inch.ConvertTheValue(Length.Unit.CENTIMETER, 0.0);
                double secondCentimeterValue = inch.ConvertTheValue(Length.Unit.CENTIMETER, 1.0);
                Assert.AreNotEqual(firstCentiMeterValue, secondCentimeterValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}