using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MenuViewModel
    {
        public List<MenuViewModel> Childs { get; set; }
        public Menu Content { get; set; }
        public String Display { get; set; }
    }
}
