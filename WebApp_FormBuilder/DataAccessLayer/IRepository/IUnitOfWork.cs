using DataAccessLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IUnitOfWork
    {
        IFormRepository FormBuilder { get; }
        void Save();
    }
}
