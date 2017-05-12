using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using ViewModel.Facebook;

namespace WebCommerce.Controllers.api
{
    public class FacebookInfoController : ApiController
    {
        [HttpPost]
        public object SaveInfo([FromBody]FacebookParameterViewModel data)
        {
            String idToken = data.IdToken;
            dynamic facebookData = data.FacebookData;
            return new { data = "success" };
        }
    }
}
