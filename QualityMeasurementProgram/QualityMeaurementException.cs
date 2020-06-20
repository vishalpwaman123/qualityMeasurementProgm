using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurementProgram
{
    public class QualityMeaurementException : Exception
    {
        public ExceptionType Type;

        public string message;
        public QualityMeaurementException(string message, ExceptionType type)
        {
            this.Type = type;
            this.message = message;
        }

        public enum ExceptionType
        {
            INVALID_ARGUMENT,
            UNWANTED_EXCEPTION
        }
    }

}
