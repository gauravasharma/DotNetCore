using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sample2.Models;
using sample2.Services.Interface;
using sample2.EntityFramework;
namespace Sample2.Services.Implementation
{
  public class DataElementRepository : IDataElementRepository
  {
        private DataContext _context;

        public DataElementRepository(DataContext context)
        {
            _context=context;
        }

        public IEnumerable<DataElement> GetAll()
        {
           return _context.DataElement.OrderBy(r => r.ElementShortName);
        }
        public DataElement Get(int id)
        {
           return null;
        }
        public DataElement Add(DataElement dataElement)
        {
            return null;
        }
    
  }
}
