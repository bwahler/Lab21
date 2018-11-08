using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop.Models
{
    public class UserInfo
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^([0-9A-z]{5,30})(@[0-9A-z]{5,10}).([0-9A-z]{2,3})$")]
        public string EmailAddress { set; get; }

        [Required]
        [RegularExpression(@"^(\d{3})-(\d{3})-(\d{4})$")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]\w{3,14}$")]
        public string Password { set; get; }
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            EmailAddress = "";
            PhoneNumber = "";
            Password = "";
        }

        public UserInfo(string fn, string ln, string ea, string pn, string p)
        {
            FirstName = fn;
            LastName = ln;
            EmailAddress = ea;
            PhoneNumber = pn;
            Password = p;
        }
    }
}