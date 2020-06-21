using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
    class VolumeTestCase
    {
        private Volumes litre = null;
        private Volumes gallon = null;

        [SetUp]
        public void Setup()
        {
            this.litre = new Volumes();
            this.gallon = new Volumes();
        }

        [Test]
        public void Given0GallonAnd0Gallon_ShouldReturnsEqual()
        {
            try
            {
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 0.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 0.0);
                Assert.AreEqual(firstGallonValue, secondGallonValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0GallonAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 0.0);
                Volumes secondGallonValue = null;
                Assert.AreNotEqual(firstGallonValue, secondGallonValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Volumes firstObject = new Volumes();
                Volumes secondObject = new Volumes();
                bool areEqual = System.Object.ReferenceEquals(firstObject, secondObject);
                Assert.IsFalse(areEqual);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Volumes firstObject = new Volumes();
                Volumes secondObject = new Volumes();
                firstObject = secondObject;
                bool areEqual = System.Object.ReferenceEquals(firstObject, secondObject);
                Assert.IsTrue(areEqual);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT,e.Type);
            }
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 3.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 3.0);
                Assert.AreEqual(firstGallonValue.GetType(), secondGallonValue.GetType());
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroGallonAndOneGallon_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 0.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.Gallon, 1.0);
                Assert.AreNotEqual(firstGallonValue, secondGallonValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroLitreAndZeroLitre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstLitreValue = litre.ConvertValueToInch(Volumes.Unit.Litre, 0.0);
                double secondLitreValue = litre.ConvertValueToInch(Volumes.Unit.Litre, 0.0);
                Assert.AreEqual(firstLitreValue, secondLitreValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}
