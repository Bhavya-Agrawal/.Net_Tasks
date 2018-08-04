using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sumapi.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> numbers = new List<string>() {
            "value0" , "value1"
        };

        int summission = 0;
        // GET api/values
        public IEnumerable<string> Get()
        {
            return numbers;
        }

        // GET api/values/5
        public int Get(int summission)
        {
            return summission;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
               numbers.Add(summission.ToString());
        }

        public void Call(int a,int b)
        {
            numbers[a] = b.ToString();
            Sum(a,b);
        }
        public int Sum(int a,int m)
        {
            summission = summission + m;
            //Get();
            //Get(summission);
            Post(summission.ToString());
            return summission;
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]int value)
        {
            Call(id,value);
        }

       
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
