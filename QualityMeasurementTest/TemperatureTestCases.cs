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
        private Temperature celsius = null;

        [SetUp]
        public void Setup()
        {
            this.fahrenheit = new Temperature();
            this.celsius = new Temperature();
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

        [Test]
        public void Given0CelsiusAnd0Celsius_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstCelsiusValue = celsius.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
                double secondCelsiusValue = celsius.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
                Assert.AreEqual(firstCelsiusValue, secondCelsiusValue);
            }
            catch (QualityMeaurementException e)
            {
                Assert.AreEqual(QualityMeaurementException.ExceptionType.INVALID_ARGUMENT, e.Type);
            }
        }
    }
}