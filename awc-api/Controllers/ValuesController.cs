using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace awc_api.Controllers
{

    public class User
    {
        public User(string firstName, string lastName, string email, string activity, string comments)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.activity = activity;
            this.comments = comments;
        }

        public string firstName { get; }
        public string lastName { get; }
        public string email { get; }
        public string activity { get; }
        public string comments { get; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            User usr1 = new User("Jim", "Johns", "email1@address.com", "Bowling", "");
            User usr2 = new User("Joe", "Smith", "email2@address.com", "Biking", "test");
            return new User[] { usr1, usr2 };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User value)
        {
            System.Diagnostics.Debug.WriteLine(User);
        }
    }
}
