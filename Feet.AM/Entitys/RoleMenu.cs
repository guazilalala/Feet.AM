﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feet.AM.Entitys
{
    public class RoleMenu
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
