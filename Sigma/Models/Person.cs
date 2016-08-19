using System.Collections.Generic;

namespace Sigma.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Friend> Friends { get; set; }
    }
    public class Friend
    {
        public string Name { get; set; }
        public bool IsOnTwitter { get; set; }
        public string TwitterName { get; set; }
    }
}