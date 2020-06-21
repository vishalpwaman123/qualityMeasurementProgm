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
            GRAMStoKILOGRAMS
        }

        public Weight()
        {

        }
        public double ConvertValueToKiloGrams(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GRAMStoKILOGRAMS))
                {
                    return value / 1000;
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
