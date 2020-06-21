﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QualityMeasurementProgram;

namespace NUnitTestQuantityMeasurement
{
    class WeightTestCase
    {
        private Weight kiloGram = null;
        private Weight gram = null;

        [SetUp]
        public void Setup()
        {
            this.kiloGram = new Weight();
            this.gram = new Weight();
        }

        [Test]
        public void Given0KiloGramsAnd0KiloGrams_ShouldReturnsEqual()
        {
            try
            {
                double firstKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 0.0);
                double secondKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 0.0);
                Assert.AreEqual(firstKiloGramsValue, secondKiloGramsValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0KiloGramsAnd1KiloGrams_ShouldReturnsEqual()
        {
            try
            {
                double firstKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 0.0);
                double secondKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 1.0);
                Assert.AreNotEqual(firstKiloGramsValue, secondKiloGramsValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0GramsAnd0Grams_ShouldReturnsEqual()
        {
            try
            {
                double firstGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GRAMStoKILOGRAMS, 0.0);
                double secondGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GRAMStoKILOGRAMS, 0.0);
                Assert.AreEqual(firstGramsValue, secondGramsValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0GramsAnd1Grams_ShouldReturnsEqual()
        {
            try
            {
                double firstGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GRAMStoKILOGRAMS, 0.0);
                double secondGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GRAMStoKILOGRAMS, 1.0);
                Assert.AreNotEqual(firstGramsValue, secondGramsValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given1KiloGramAnd1000Grams_ShouldReturnsEqual()
        {
            try
            {
                double kiloGramValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 1.0);
                double gramValue = gram.ConvertValueToKiloGrams(Weight.Unit.GRAMStoKILOGRAMS, 1000.0);
                Assert.AreEqual(kiloGramValue, gramValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}