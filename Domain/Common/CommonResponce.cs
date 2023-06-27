using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class CommonResponce<T>
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public dynamic? Response { get; set; }
    }
}
