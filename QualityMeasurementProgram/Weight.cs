using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
    public class Weight
    {
        public enum Unit
        {
            KILOGRAMS,
            GRAMS,
            GRAMStoKILOGRAMS,
            TONNEtoKILOGRAM
        }

        public Weight()
        {

        }
        public double AddTwoWeight(double firstKiloGramValue, double secondKiloGramValue)
        {
            return firstKiloGramValue + secondKiloGramValue;
        }
        public double ConvertValueToKiloGrams(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GRAMStoKILOGRAMS))
                {
                    return value / 1000;
                }
                if (unit.Equals(Unit.TONNEtoKILOGRAM))
                {
                    return value * 1000;
                }
                return value;
            }
            catch (QualityMeaurementException e)
            {
                throw new QualityMeaurementException(e.Message, QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
            }
        }

    }
}