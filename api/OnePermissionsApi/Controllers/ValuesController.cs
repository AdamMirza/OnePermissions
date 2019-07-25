using System;
using System.Collections.Generic;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnePermissionsApi.Model;

namespace OnePermissionsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{alias}")]
        public ActionResult<object> Get(string alias)
        {
            alias = alias.ToLower();
            alias += "@microsoft.com";

            string allText = System.IO.File.ReadAllText(@".\Data\data.json");

            object jsonObject = JsonConvert.DeserializeObject(allText);
            return jsonObject;

            return new UserPermissions()
            {
                Alias = alias,
            };
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
