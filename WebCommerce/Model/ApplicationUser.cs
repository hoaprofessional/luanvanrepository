using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ApplicationUser : IdentityUser, IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public string UpdatedBy { set; get; }
        [DefaultValue(true)]
        public bool Status { set; get; }
        public String FacebookId { get; set; }
        public String Name { get; set; }
        public String Avatar { get; set; }
        public int Bonus { get; set; }
    }
}
