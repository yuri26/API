using Efectura.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efectura.Data.DataContext
{
    public class EfectraContext: DbContext
    {
        private readonly DbContextOptions _options;

        public EfectraContext(DbContextOptions<EfectraContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<Consumer> Consumers { get; set; }

    }
   
}
