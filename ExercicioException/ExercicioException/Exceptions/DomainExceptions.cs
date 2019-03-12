using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioException.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
