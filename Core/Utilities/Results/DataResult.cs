using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool Success, string message) : base(Success, message)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
