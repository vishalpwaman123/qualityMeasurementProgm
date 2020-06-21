using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
    public class Temperature
    {
        public enum Unit
        {
            Celsius,
            Fahrenheit,
            FahrenheitToCelsius
        }

        public double ConvertValueToCelsius(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.FahrenheitToCelsius))
                {
                    return value * (100 / 212);
                }

                return value;
            }
            catch (Exception e)
            {
                throw new QualityMeaurementException(e.Message, QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
            }
        }
    }
}