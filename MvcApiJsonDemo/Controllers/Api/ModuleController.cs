using MvcApiJsonDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApiJsonDemo.Controllers.Api
{
    public class ModuleController : ApiController
    {
        private List<Module> modules = new List<Module>()
            {
                new Module{Id = 0, Naam = "test module a" },
                 new Module{Id = 1, Naam = "test module b" },
            };

        // GET api/<controller>
        public IEnumerable<Module> Get()
        {
            return modules;
        }

        // GET api/<controller>/5
        public Module Get(int id)
        {
            return modules.SingleOrDefault(m => m.Id == id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}