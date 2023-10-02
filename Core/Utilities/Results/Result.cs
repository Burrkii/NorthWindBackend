using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool Success, string message)
        {
            IsSuccess = Success;
            Message = message;
        }

        public bool IsSuccess { get; }
        public string Message { get; }
    }
}
