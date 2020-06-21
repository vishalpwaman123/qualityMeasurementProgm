using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
   public class Volumes
    { 
        public enum Unit
        {
            GALLON,
            LITRE,
            GALLONToLITRE,
            MILILITREToLITRE
        }

        public double ConvertValueToInch(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GALLONToLITRE))
                {
                    return value * 3.78;
                }else if(unit.Equals(Unit.MILILITREToLITRE))
                {
                    return value / 1000.0;
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
