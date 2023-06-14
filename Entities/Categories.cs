using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Entities
{
    public class Categories : BaseEntity
    {
       public string Name  {get; set;} 
       public string  Description {get; set;}
       public ICollection<AgeCategories> AgeCategories { get; set; } = new HashSet<AgeCategories>();
    }
}