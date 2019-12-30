using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TarziniYaratProject.UI.Models
{
    public class PersonVM
    {
        public int PersonID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}