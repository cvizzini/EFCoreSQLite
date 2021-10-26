using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatDemo.Context
{
    public partial class DataContext
    {
        public class ApplicationContextDatabaseFactory : IDesignTimeDbContextFactory<DataContext>
        {
            DataContext IDesignTimeDbContextFactory<DataContext>.CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

                return new DataContext(optionsBuilder.Options);
            }
        }
    }
}
