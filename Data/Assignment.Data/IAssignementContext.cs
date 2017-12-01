using Assignment.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Assignment.Data
{
    public interface IAssignmentContext : IDisposable, IObjectContextAdapter
    {
        IDbSet<Event> Events { get; set; }

        Database Database { get; }

        DbContextConfiguration Configuration { get; }

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;


    }
}
