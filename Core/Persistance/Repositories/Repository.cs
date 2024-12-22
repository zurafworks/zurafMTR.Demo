﻿using Core.Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
{
    private readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().AnyAsync(predicate);
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().CountAsync(predicate);
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
        }
        return await query.ToListAsync();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
        }
        return await query.SingleOrDefaultAsync(); ;
    }

    public async Task SoftDeleteAsync(TEntity entity)
    {
        await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        return entity;
    }
}
