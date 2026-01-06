using System;
using System.Reflection;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException

    {
        public NotFoundException(string message) : base(message)
        {


        }
    }
}
