using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
   public class Length
    {
        public enum Unit { FEET, INCH }

        private Unit unit;
        private double value;

        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public Length(Unit unit, string value)
        {
            throw new QualityMeaurementException("Invalid Argument", QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
        }

        public bool Compare(Length inchValue)
        {
            return true;
        }

        public override bool Equals(object o)
        {
            // It checks for the Object
            if (this == o)
            {
                return true;
            }

            // It checks for object if null or object type is not equal then return false
            if (o == null || !this.GetType().Equals(o.GetType()))
            {
                return false;
            }

            Length length = (Length)o;
            return value.CompareTo(length.value) == 0 & unit == length.unit;
        }
    }
}
