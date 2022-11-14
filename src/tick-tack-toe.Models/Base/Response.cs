using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe.Models.Base
{
    public class Response<T> where T : class
    {
        public bool Success { get; set; }

        public double TimeStamp
        {
            get { return DateTimeOffset.Now.ToUnixTimeSeconds(); }      
        }

        public T? Result { get; set; }

        public Error? Error { get; set; }
    }
}
