using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Exceptions
{
    public class PersonaException : Exception
    {
        public PersonaException(string message) :base(message)
        {

        }
    }
}
