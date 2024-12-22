﻿using Core.Domain.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Concrete;

public class User : IdentityUser<int>, IEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
