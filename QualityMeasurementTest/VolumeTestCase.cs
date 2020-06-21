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
        private Volumes miliLitre = null;

        [SetUp]
        public void Setup()
        {
            this.litre = new Volumes();
            this.gallon = new Volumes();
            this.miliLitre = new Volumes();
        }

        [Test]
        public void Given0GallonAnd0Gallon_ShouldReturnsEqual()
        {
            try
            {
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 0.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 0.0);
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
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 0.0);
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
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 3.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 3.0);
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
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 0.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLON, 1.0);
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
                double firstLitreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 0.0);
                double secondLitreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 0.0);
                Assert.AreEqual(firstLitreValue, secondLitreValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroLitreAndOneLitre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstLitreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 0.0);
                double secondLitreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 1.0);
                Assert.AreNotEqual(firstLitreValue, secondLitreValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenOneGallonAndThreePoint78Litre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double gallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLONToLITRE, 0.0);
                double litreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 3.78);
                Assert.AreNotEqual(gallonValue, litreValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void GivenZeroMiliLitreAndZeroMiliLitre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstMiliLitreValue = miliLitre.ConvertValueToInch(Volumes.Unit.MILILITREToLITRE, 0.0);
                double secondMiliLitreValue = miliLitre.ConvertValueToInch(Volumes.Unit.MILILITREToLITRE, 0.0);
                Assert.AreEqual(firstMiliLitreValue, secondMiliLitreValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1LitreAnd1000MiliLitre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double litreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 1.0);
                double miliLitreValue = miliLitre.ConvertValueToInch(Volumes.Unit.MILILITREToLITRE, 1000.0);
                Assert.AreEqual(litreValue, miliLitreValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1LitreAnd1Litre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstLitreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 1.0);
                double secondLitreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 1.0);
                double ActualValue = litre.AddTwoVolume(firstLitreValue, secondLitreValue);
                double ExpectedValue = 2.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1GallonAnd1Gallon_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLONToLITRE, 1.0);
                double secondGallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLONToLITRE, 1.0);
                double ActualValue = litre.AddTwoVolume(firstGallonValue, secondGallonValue);
                double ExpectedValue = 7.56;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1GallonAnd3point78Litre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double gallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLONToLITRE, 1.0);
                double litreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 3.78);
                double ActualValue = litre.AddTwoVolume(gallonValue, litreValue);
                double ExpectedValue = 7.56;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1LitreAnd1000MiliLitre_WhenAdded_ShouldReturnAddition()
        {
            try
            {
                double litreValue = litre.ConvertValueToInch(Volumes.Unit.LITRE, 1.0);
                double miliLitreValue = miliLitre.ConvertValueToInch(Volumes.Unit.MILILITREToLITRE, 1000.0);
                double ActualValue = litre.AddTwoVolume(litreValue, miliLitreValue);
                double ExpectedValue = 2.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1GallonAnd1000MiliLitre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double gallonValue = gallon.ConvertValueToInch(Volumes.Unit.GALLONToLITRE, 1.0);
                double miliLitreValue = miliLitre.ConvertValueToInch(Volumes.Unit.MILILITREToLITRE, 1000.0);
                double ActualValue = litre.AddTwoVolume(gallonValue, miliLitreValue);
                double ExpectedValue = 4.78;
                Assert.AreEqual(ExpectedValue, Math.Round(ActualValue, 2));
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}
