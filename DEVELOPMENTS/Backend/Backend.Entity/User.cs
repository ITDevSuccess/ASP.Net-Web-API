﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entity
{
    public class User : Entity
    {
        public virtual string User_FirstName { get; set; }
        public virtual string User_LastName { get; set; }
        public virtual string User_CIN { get; set; }
        public virtual DateTime User_BirthDay { get; set; }
    }
}
