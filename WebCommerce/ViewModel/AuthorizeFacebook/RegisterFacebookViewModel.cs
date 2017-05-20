
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModel.AuthorizeFacebook
{
    public class RegisterFacebookViewModel
    {
        [Required]
        public String FacebookTokenId { get; set; }
        public String Email { get; set; }
        public String Name { get; set; }
        public String Avatar { get; set; }
    }
}
