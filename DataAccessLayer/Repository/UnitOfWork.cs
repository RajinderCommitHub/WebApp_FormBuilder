using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
          private readonly ApplicationDbContext _context;

           public UnitOfWork(ApplicationDbContext context)
           {
              _context = context;
              FormBuilder = new FormRepository(_context);
           }
        public IFormRepository FormBuilder { private set;get; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
