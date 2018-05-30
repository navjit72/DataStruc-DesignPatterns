using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassActivity_Composite
{
    public class CustomException : Exception
    {
        string Message;
        public CustomException(String message)
        {
            Message = message;
        }
    }
}
