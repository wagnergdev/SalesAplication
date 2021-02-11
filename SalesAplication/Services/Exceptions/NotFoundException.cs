using System;

namespace SalesAplication.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
                
        }
    }
}
