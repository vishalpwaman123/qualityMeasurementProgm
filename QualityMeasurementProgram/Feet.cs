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

            Feet feet = (Feet)o;
            return value.CompareTo(feet.value) == 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
    }
}
