using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactManager.Controllers
{
    public class Test
    {
        public DateTime Created { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public IDictionary<string, string> IDictionary { get { return dictionary; } }

        public Test()
        {
            Created = DateTime.Now;
            DayOfWeek = DateTime.Now.DayOfWeek;
        }

        private IDictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"Json.NET","A really good JSON serializer"},
            {"Web API","A great framework for building HTTP services"}
        };
    }

    public class ValuesController : ApiController
    {
        public string Post(dynamic data)
        {
            return "Hello, " + data.Name;
        }

        public Test Get()
        {
            return new Test();
        }

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //public string Get(int id)
        //{
        //    return "value";
        //}

        //public void Post([FromBody]string value)
        //{
        //}

        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //public void Delete(int id)
        //{
        //}

    }
}