using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Models.Return
{
    
        public class ReturnResponseModel : BaseResponseModel
           {
           public ReturnViewModel Data { get; set; }
           }

         public class ReturnsResponseModel : BaseResponseModel
           {
            public List<ReturnViewModel> Data { get; set; }
           } 
    
}