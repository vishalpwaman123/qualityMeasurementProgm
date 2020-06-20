using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
    public class Feet
    {
        private double value;

        public Feet(double value)
        {
            this.value = value;
        }

        public Feet(string value)
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

            Feet feet = (Feet)object_parameter;
            return value.CompareTo(feet.value) == 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }
}
