using AdminGirisi.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGirisi.ORM.Context
{
    class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=RentACarDeneme;uid=sa;pwd=1234";
        }

        public DbSet<Arabalar> Cars { get; set; }
        public DbSet<Musteriler> Customers { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
       
    }

}
