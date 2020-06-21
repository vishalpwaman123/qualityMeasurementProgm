using System;
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
            double firstKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 0.0);
            double secondKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 0.0);
            Assert.AreEqual(firstKiloGramsValue, secondKiloGramsValue);
        }
    }
}