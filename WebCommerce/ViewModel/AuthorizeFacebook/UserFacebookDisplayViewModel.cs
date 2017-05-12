using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;


namespace ViewModel.AuthorizeFacebook
{
    public class UserFacebookDisplayViewModel 
    {
        public String Name { get; set; }
        public String Email { get; set; }
    }
}
