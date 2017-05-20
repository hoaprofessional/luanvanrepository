using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.Home
{
    public class SellerViewModel : BaseViewModel<ApplicationUser>
    {
        public String Name { get; set; }
        public String Avatar { get; set; }
        public int Bonus { get; set; }
    }
}
