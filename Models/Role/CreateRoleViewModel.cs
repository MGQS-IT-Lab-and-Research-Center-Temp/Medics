using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Models.Role
{
    public class CreateRoleViewModel
    {
        [Required(ErrorMessage = "Role name is required!")]
        [MinLength(3, ErrorMessage = "The minimum length acceptable is 3")]
        [MaxLength(50, ErrorMessage = "The maximum length acceptable is 50")]
        public string RoleName { get; set; }

        [MinLength(5, ErrorMessage = "The minimum length acceptable is 5")]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}