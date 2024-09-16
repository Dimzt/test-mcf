using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Models;
using Microsoft.EntityFrameworkCore;

namespace mcfapi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<tr_bpkb> tr_bpkb { get; set; }
        public DbSet<ms_user> ms_user { get; set; }
        public DbSet<ms_storage_location> ms_storage_location { get; set; }
    }
}