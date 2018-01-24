using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestIdentity.Models
{
    public class PNCModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string VerifcationKey { get; set; }

        public int SMSKey { get; set; }

        //is foreign key
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User {get; set;}
    }
}