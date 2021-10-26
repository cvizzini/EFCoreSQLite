using ChatDemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatDemo.Context
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }


        public void MigrateDefaultData()
        {
            for (int i = 1; i <= 10; i++)
            {
                var existing = Messages.FirstOrDefault(x => x.Id == i);
                if (existing is not null) break;

                var message = new Message() { Id = i, CreatedAt = DateTime.Now, Name = $"Test{i}", Text = $"This is message {i}" };
                Messages.Add(message);
            }
            SaveChanges();
        }
    }
}
