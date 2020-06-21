using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
   public class Length
    {
        public enum Unit {
            FEET,
            INCH, 
            YARD,
            FEETToINCH,
            YARDToINCH,
            CENTIMETER
        }

        private Unit unit;
        private double value;
        
        public Length()
        {
            
        }

        public double ConvertTheValue(Unit unit, double value)
        {
            
                if (unit.Equals(Unit.FEETToINCH))
                {
                    return value * 12.0;
                }
                else if (unit.Equals(Unit.YARDToINCH))
                {
                    return value * 36.0;
                }
                return value;
        }
        public Length(Unit unit, string value)
        {
            throw new QualityMeaurementException("Invalid Argument", QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
        }

        public override bool Equals(object object_parameter)
        {
            // It checks for the Object
            if (this == object_parameter)
            {
                return true;
            }

            // It checks for object if null or object type is not equal then return false
            if (object_parameter == null || !this.GetType().Equals(object_parameter.GetType()))
            {
                return false;
            }

            Length length = (Length)object_parameter;
            return value.CompareTo(length.value) == 0 & unit == length.unit;
        }
    }
}
