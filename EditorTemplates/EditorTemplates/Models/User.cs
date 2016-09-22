using System;
using System.Collections.Generic;

namespace EditorTemplates.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; }
        public List<Role> Roles { get; set; }
        public List<Address> Addresses { get; set; }
    }
}