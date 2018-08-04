using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApi.Controllers
{
    public class ValuesController : ApiController
    {
        //the llist will contain string type of the values
        static List<string> strings = new List<string>() {
            "value0" , "value1" , "value2"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return strings;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return id.ToString();
            //this Get funcion will retirn the value of the list at the given ID 
            return strings[id];
        }

        // POST api/values
        //Post is equivalent to Creating or adding the database
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT api/values/5
        //Put method is equlivalent to updating the database
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        //works similar to delete in database
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }   
    }
}
