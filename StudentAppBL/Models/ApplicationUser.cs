using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAppBL.Models
{
    public class abc : IdentityUser
    {
        public string City { get; set; }
    }

}
   
