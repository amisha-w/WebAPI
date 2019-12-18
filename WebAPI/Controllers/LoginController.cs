using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        public IHttpActionResult Post([FromBody]Class1 o)
        {
            try
            {

                Model1 db = new Model1();
                //The operation cannot be completed because the DbContext has been disposed.

                var obj = db.People.Where(a => a.username.Equals(o.username) && a.password.Equals(o.password)).FirstOrDefault();

                return Ok(obj);
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
