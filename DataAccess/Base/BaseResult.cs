using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Base
{
    public class BaseResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public List<BaseError> Errors { get; set; } = new List<BaseError>();
    }
}
