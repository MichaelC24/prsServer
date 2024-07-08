using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prsServer.Model;

namespace prsServer.Data
{
    public class prsServerContext : DbContext
    {
        public prsServerContext (DbContextOptions<prsServerContext> options)
            : base(options)
        {
        }

        public DbSet<prsServer.Model.Users> Users { get; set; } = default!;
        public DbSet<prsServer.Model.Vendors> Vendors { get; set; } = default!;
        public DbSet<prsServer.Model.Products> Products { get; set; } = default!;
        public DbSet<prsServer.Model.Requests> Requests { get; set; } = default!;
        public DbSet<prsServer.Model.RequestLines> RequestLines { get; set; } = default!;
    }
}
