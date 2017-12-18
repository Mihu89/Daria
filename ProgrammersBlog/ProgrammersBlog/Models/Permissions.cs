﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammersBlog.Models
{
    public class Permissions
    {
        public int PermissionsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Role> Roles { get; set; }

        public Permissions()
        {
           Roles = new List<Role>();
        }
    }
}