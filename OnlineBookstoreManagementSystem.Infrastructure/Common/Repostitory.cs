using Microsoft.EntityFrameworkCore;
using OnlineBookstoreManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstoreManagementSystem.Infrastructure.Common
{
    public class Repostitory : IRepository
    {
        private readonly ApplicationDbContext context;
        public Repostitory(ApplicationDbContext _context)
        {
            context = _context;
        }
        private DbSet<T> DbSet<T>() where T : class 
        {
            return this.context.Set<T>();
        }
        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>()
                .AsNoTracking();
        }
    }
}
