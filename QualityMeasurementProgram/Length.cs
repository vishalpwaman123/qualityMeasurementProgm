﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
   public class Length
    {
        public enum Unit { FEET, INCH }

        private Unit unit;
        private double value;
        private double FeetToInch = 12.0;

        public Length(Unit unit, double value)
        {
            this.unit = unit;
            if (value.Equals(typeof(string)))
            {
                throw new QualityMeaurementException("Invalid Argument", QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
            }
            this.value = value;
        }

        public Length(Unit unit, string value)
        {
            throw new QualityMeaurementException("Invalid Argument", QualityMeaurementException.ExceptionType.INVALID_ARGUMENT);
        }

        public bool Compare(Length Value)
        {  
            if(this.value.Equals(Value.value))
            {
                return true;
            }
            if (this.unit.Equals(Unit.FEET) && Value.unit.Equals(Unit.INCH))
            {
                return Value.value.CompareTo(this.value * FeetToInch) == 0;
            }
            return false;
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