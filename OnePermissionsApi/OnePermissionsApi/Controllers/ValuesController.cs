using System;
using System.Collections.Generic;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<UserPermissions> Get(string alias)
        {
            // Check valid email
            try
            {
                MailAddress m = new MailAddress(alias);
                if (m.Host.ToLower() != "microsoft.com")
                {
                    throw new FormatException("Not an alias");
                }

            }
            catch (FormatException)
            {
                return new UserPermissions()
                {
                    Success = false
                };
            }

            return new UserPermissions()
            {
                Alias = alias.ToLower(),
                Success = true
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
