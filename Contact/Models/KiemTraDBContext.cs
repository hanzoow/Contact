using Contact.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Models
{
    public class KiemTraDBContext : DbContext
    {
        public KiemTraDBContext() :
base("Data Source=.;Initial Catalog=Csharp;Persist Security Info=True;User ID=sa;Password=123")
        {

        }

  
        public DbSet<NhomDanhBa> NhomDanhBaDbSet { get; set; }
        public DbSet<ChiTietDanhBa> ChiTietDanhBaDbSet { get; set; }
    }
}
