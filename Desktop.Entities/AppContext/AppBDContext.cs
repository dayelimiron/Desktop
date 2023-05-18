using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entities.AppContext
{
    internal class AppBDContext : DbContext
    {
        public AppBDContext() : base("conn")
        {

        }
        public DbSet<Desktopp> Desktops { get; set; }
        public DbSet<Computo> Computos { get; set; }
    }
}
