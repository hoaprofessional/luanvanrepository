using Model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebCommerce.Controllers
{
    public class DemoController : ApiController
    {
        private IDemoService _demoService;
        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }
        // GET api/<controller>
        public IEnumerable<Demo> Get()
        {
            return _demoService.GetAll();
        }

        // GET api/<controller>/5
        public Demo Get(int id)
        {
            return _demoService.GetById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Demo value)
        {
            if(ModelState.IsValid)
            {
                _demoService.Add(value);
                _demoService.Save();
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Demo value)
        {
            if (ModelState.IsValid)
            {
                value.Id = id;
                _demoService.Update(value);
                _demoService.Save();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _demoService.Delete(id);
            _demoService.Save();
        }
    }
}