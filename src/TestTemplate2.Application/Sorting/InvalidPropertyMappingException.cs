using System;

namespace TestTemplate2.Application.Sorting
{
    public class InvalidPropertyMappingException : Exception
    {
        public InvalidPropertyMappingException(string message)
            : base(message)
        {
        }
    }
}
