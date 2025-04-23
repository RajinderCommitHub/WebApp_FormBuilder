using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class FormRepository : GenRepository<FormBuilder> ,IFormRepository
    {
        private readonly ApplicationDbContext _context;
        public FormRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
