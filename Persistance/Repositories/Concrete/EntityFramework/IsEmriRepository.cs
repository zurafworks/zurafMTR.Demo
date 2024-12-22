using Core.Persistance.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Concrete.EntityFramework;

public class IsEmriRepository : Repository<IsEmri>, IIsEmriRepository
{
    public IsEmriRepository(DbContext context) : base(context)
    {
    }
}
