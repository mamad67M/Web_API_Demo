using API_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Demo.Controllers
{
    public class PeopleController : ApiController
    {
        private readonly List<Person> People = new List<Person>();

        public PeopleController()
        {
            People.Add(new Person(1, "mamadou", "Yanis"));
            People.Add(new Person(2, "Yanis", "Mamadou"));
            People.Add(new Person(3, "Baldé", "Sekou"));
            People.Add(new Person(4, "mamadou", "Calista"));
        }

        [Route("api/People/GetPrenom")]
        //[HttpGet]
       public List<string> GetPrenom()
        {
            List<string> prenoms = new List<string>();

            foreach (var item in People)
            {
                prenoms.Add(item.prenom);
            }
            return prenoms;
        }



        // GET: api/People
        public List<Person> Get()
        {
            return People;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            Person p = People.FirstOrDefault(x=>x.id == id);
            return p;
        }

        // POST: api/People
        public void Post(Person p)
        {
            People.Add(p);
        }

        //// PUT: api/People/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
