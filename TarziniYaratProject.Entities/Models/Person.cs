﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Person : IEntity
    {
        public Person()
        {
            Comments = new HashSet<Comment>();
            Combines = new HashSet<Combine>();
            Addresses = new HashSet<Address>();
            Purchases = new HashSet<Purchase>();
            Likes = new HashSet<Like>();
        }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public PersonType PersonType { get; set; }
        public bool IsActive { get; set; } // if it is false, it means user is banned.
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Combine> Combines { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual Image Image { get; set; }
    }

    public enum PersonType
    {
        Member,
        Modellist,
        Admin
    }
}
