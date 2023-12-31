using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Models.Drug
{
    
        
        public class DrugResponseModel : BaseResponseModel
        {
            public DrugViewModel Data { get; set; }
        }

        public class DrugsResponseModel : BaseResponseModel
        {
            public List<DrugViewModel> Data { get; set; }
        }
}