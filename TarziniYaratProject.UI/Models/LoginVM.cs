using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.UI.Models
{
    public class LoginVM:IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}