using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Models
{
    public class BaseResponseModel
    {
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}