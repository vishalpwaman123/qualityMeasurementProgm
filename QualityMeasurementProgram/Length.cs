using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
   public class Length
    {
        public enum Unit { FEET, INCH ,YARD , FEETToINCH, YARDToINCH }

        private Unit unit;
        private double value;
        private double FeetToInch = 12.0;
        private double InchToFeet = 12.0;
        private double FeetToYard = 3.0;
        private double YardToInch = 36.0;
        private double InchToYard = 36.0;
        private double YardToFeet = 3.0;


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
