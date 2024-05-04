﻿using Education.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Domain.Entities
{
    public class WishList
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public virtual UserModel User { get; set; }
        public virtual List<CourseModel> Courses { get; set; }
    }
}
