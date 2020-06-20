using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
    public class Inch
    {
        private double value;

        public Inch(double value)
        {
            this.value = value;
        }

        public Inch(string value)
        {
            throw new QualityMeaurementException("Invalid Argument", QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
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

            Inch inch = (Inch)o;
            return value.CompareTo(inch.value) == 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }

}
