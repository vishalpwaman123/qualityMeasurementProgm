using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
   public class Volumes
    { 
        public enum Unit
        {
            Gallon,
            Litre,
            GallonToLitre
        }

        public double ConvertValueToInch(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GallonToLitre))
                {
                    return value * 3.78;
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
