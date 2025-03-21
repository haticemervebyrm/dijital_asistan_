using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using dijital_asistan.Data;
using Microsoft.EntityFrameworkCore;
using dijital_asistan.Abstract;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public List<T> GetAll() => _dbSet.ToList();

    public T GetByFilter(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefault(predicate);

    public T GetById(int id) => _dbSet.Find(id);

    public void Create(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }

    public int Count() => _dbSet.Count();

    public int FilteredCount(Expression<Func<T, bool>> predicate) => _dbSet.Count(predicate);

    public List<T> GetFilteredList(Expression<Func<T, bool>> predicate) => _dbSet.Where(predicate).ToList();
}
