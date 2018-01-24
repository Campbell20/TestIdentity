using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestIdentity.Models
{
    public class PNCModel
    {
        public int Id { get; set; }
        public bool IsValid { get; set; }
        //public bool IsActive { get; set; }
        public string VerifcationKey { get; set; }

        public string SMSKey { get; set; }

        ////is foreign key
        //[Key]
        //[ForeignKey("User")]
        public string UserId { get; set; }

    
        //public virtual ApplicationUser User {get; set;}
    }
}