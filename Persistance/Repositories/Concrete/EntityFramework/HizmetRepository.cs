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

public class HizmetRepository : Repository<Hizmet>, IHizmetRepository
{
    public HizmetRepository(DbContext context) : base(context)
    {
    }
}
