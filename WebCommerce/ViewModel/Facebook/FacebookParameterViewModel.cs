using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ViewModel.Facebook
{
    public class FacebookParameterViewModel
    {
        public String IdToken { get; set; }
        public FacebookDataViewModel[] FacebookData { get; set; }
    }
}
