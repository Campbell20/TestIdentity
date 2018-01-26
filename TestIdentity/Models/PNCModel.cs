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

        //setting the valid state of the model depending on if the phone number is verified
        public bool IsValid { get; set; }

        //public bool IsActive { get; set; }

        /// <summary>
        /// create a hash key based on the user's unique phone number, then when the user types in their smskey, it checks the hash to make sure it's correct. If correct, user can login, if not correct user can't login.
        /// </summary>
        public string VerifcationKey { get; set; }

        //create a random key number to send to the user
        public string SMSKey { get; set; }

        ////is foreign key
        //[Key]
        //[ForeignKey("User")]
        public string UserId { get; set; }

    
        //public virtual ApplicationUser User {get; set;}
    }
}