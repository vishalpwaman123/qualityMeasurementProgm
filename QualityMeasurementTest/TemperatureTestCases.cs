using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QualityMeasurementProgram;

namespace NUnitTestQuantityMeasurement
{
    class TemperatureTestCases
    {
        private Temperature fahrenheit = null;

        [SetUp]
        public void Setup()
        {
            this.fahrenheit = new Temperature();
        }

        [Test]
        public void Given0FahrenheitAnd0Fahrenheit_ShouldReturnsEqual()
        {
            double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            Assert.AreEqual(firstFahrenheitValue, secondFahrenheitValue);
        }
    }
}