using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Models.User
{
    public class UserViewModel
    {     
                public string Id { get; set; }
                public string UserName { get; set; }
                public string Email { get; set; }
                public string RoleId { get; set; }
                public string RoleName { get; set; }
    }
}