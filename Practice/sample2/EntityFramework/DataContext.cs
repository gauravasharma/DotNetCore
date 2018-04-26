using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample2.Models;

namespace sample2.EntityFramework
{
    public class DataContext : DbContext
    {
              public DataContext(DbContextOptions options) : base(options)
              {
                  
              }
              public DbSet<DataElement> DataElement { get; set; }
    }
}
