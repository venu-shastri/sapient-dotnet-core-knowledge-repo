using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiUsingEF.Models;

namespace ApiUsingEF.Data
{
    public class ApiUsingEFContext : DbContext
    {
        public ApiUsingEFContext (DbContextOptions<ApiUsingEFContext> options)
            : base(options)
        {
        }

        public DbSet<ApiUsingEF.Models.CreditCard> CreditCards { get; set; }
    }
}
