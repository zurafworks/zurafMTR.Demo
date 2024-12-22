using Core.Domain.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Concrete;

public class RoleClaim : IdentityRoleClaim<int>, IEntity
{
}
