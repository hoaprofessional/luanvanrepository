using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.AuthorizeFacebook
{
    public class LoginFacebookViewModel
    {
        [Required]
        public String FacebookTokenId { get; set; }
        public bool RememberMe { get; set; }
    }
}
