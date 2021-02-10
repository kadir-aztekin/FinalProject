using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorsDataResult<T> : DataResult<T>
    {
        public ErrorsDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorsDataResult(T data) : base(data, false)
        {

        }
        public ErrorsDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorsDataResult() : base(default, false)
        {

        }
    
    
    }
}
