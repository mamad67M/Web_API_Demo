using API_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Demo.Controllers
{
    public class FriendController : ApiController
    {

        private readonly List<Friend> friends = new List<Friend>();
        public FriendController()
        {
            friends.Add(new Friend(1, "Kindson", "Munonye", "Budapest", DateTime.Today));
            friends.Add(new Friend(2, "Oleander", "Yuba", "Nigeria",    DateTime.Today));
            friends.Add(new Friend(3, "Saffron", "Lawrence", "Lagos",   DateTime.Today));
            friends.Add(new Friend(4, "Jadon",   "Munonye", "Asaba",    DateTime.Today));
            friends.Add(new Friend(5, "Solace", "Okeke", "Oko",         DateTime.Today));
        }
        // GET: api/Friend
        public List<Friend> Get()
        {
            return friends;
        }

        // GET: api/Friend/5
        public Friend Get(int id)
        {
            return friends.SingleOrDefault(f => f.id == id);
        }

        // POST: api/Friend
        public List<Friend> Post([FromBody] Friend friend)
        {
            friends.Add(friend);
            return friends;
        }

        // PUT: api/Friend/5
        public List<Friend> Put(int id, [FromBody]Friend f)
        {
            var editedObj = friends.Find(o => o.id == id);
            int index = friends.IndexOf(editedObj);
            friends[index].lastname = f.lastname;
            friends[index].firstname = f.firstname;
            friends[index].location = f.location;
            return friends;
        }

        // DELETE: api/Friend/5
        public List<Friend> Delete(int id)
        {
            var deletedObj = friends.Find(o => o.id == id);
            friends.Remove(deletedObj);
            return friends;

        }
    }
}
