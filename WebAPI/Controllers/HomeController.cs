using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    
    public class HomeController : ApiController
    {
        public IEnumerable<Person> Get()
        {
            Model1 db = new Model1();
                //The operation cannot be completed because the DbContext has been disposed.
                    var obj = (from employee in db.People select employee);
                    return obj;
        }

        

        public Person Head(string username)
        {
            Model1 db = new Model1();
            //The operation cannot    be completed because the DbContext has been disposed.
            var obj = db.People.Where(a => a.username.Equals(username)).FirstOrDefault();
            return obj;
        }

        public string Delete([FromBody] Person p)
        {
            using (var context = new Model1())
            {
                var obj = context.People.Where(a => a.username.Equals(p.username)).FirstOrDefault();
                if (obj != null)
                {
                    context.People.Remove(obj);
                    context.SaveChanges();
                }


            }
            return "Deleted Record";
        }
    


/*public IEnumerable<Person> Post(string Username, string Password, string Address, string Name, string Lname, string Role)
{
     Model1 db = new Model1();
    Person p = new Person
        {
            username = Username,
            password = Password,
            address = Address,
            name = Name,
            lname = Lname,
            Role = Role
            // …
        };
        db.People.Add(p);
        db.SaveChanges();

    var obj = (from employee in db.People select employee);
    return obj;


}*/
public IEnumerable<Person> Post([FromBody]Person p)
        {
            var context = new Model1();
            var obj1 = context.People.Where(a => a.username.Equals(p.username)).FirstOrDefault();
            if (obj1 != null)
            {
                obj1.name = p.name;
                obj1.lname = p.lname;
                obj1.password = p.password;
                obj1.address = p.address;
                obj1.Role = p.Role;

            }
            else
            {

                var std = new Person()
                {
                    name = p.name,
                    lname = p.lname,
                    username = p.username,
                    password = p.password,
                    address = p.address,
                    Role = p.Role
                };
                context.People.Add(std);



            }
            context.SaveChanges();

            var obj = (from employee in context.People select employee);
            return obj;
        }
    }
}
