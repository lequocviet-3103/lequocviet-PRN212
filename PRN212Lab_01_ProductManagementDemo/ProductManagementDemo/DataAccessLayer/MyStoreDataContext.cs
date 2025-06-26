using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Linq;

namespace DataAccessLayer
{
    public class MyStoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }

}