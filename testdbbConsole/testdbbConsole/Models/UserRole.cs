﻿using System;
using System.Collections.Generic;
using System.Text;

namespace testdbbConsole.Models
{
    class UserRole
    {
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }

    }
}
