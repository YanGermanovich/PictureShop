using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace PictureShop.Controllers
{
    public class RestController : ApiController
    {
        public string Get()
        {
            string[] data = new string[] { "Get" };
			string json = JsonConvert.SerializeObject(data, Formatting.Indented);

			return json;
        }

		public string Get(int id)
		{
            string[] data = new string[] { "Get with id", id.ToString() };
			string json = JsonConvert.SerializeObject(data, Formatting.Indented);

			return json;
		}

		public string Post()
		{
            string[] data = new string[] { "Post" };
			string json = JsonConvert.SerializeObject(data, Formatting.Indented);

			return json;
		}

        [System.Web.Mvc.HttpPut]
		public string Put(int id)
		{
            string[] data = new string[] { "Put", "id="+id.ToString()};
			string json = JsonConvert.SerializeObject(data, Formatting.Indented);

			return json;
		} 
    }
}
