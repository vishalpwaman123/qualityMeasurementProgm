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
            try
            {
                double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
                double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
                Assert.AreEqual(firstFahrenheitValue, secondFahrenheitValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }

        [Test]
        public void Given0FahrenheitAnd1Fahrenheit_ShouldReturnNotEqual()
        {
            try
            {
                double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
                double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 1.0);
                Assert.AreNotEqual(firstFahrenheitValue, secondFahrenheitValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}