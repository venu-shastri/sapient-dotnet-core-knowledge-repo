
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMDemoUsingEFCore
{
    //DataBase Name
  public  class CardManagementContext:DbContext
    {
        //Table
        public DbSet<Models.CreditCard> CreditCards { get; set; }
        public string dbFileName = "";

        public CardManagementContext()
        {
          dbFileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}{System.IO.Path.DirectorySeparatorChar}cardManagement.db";

        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite($"Data Source={dbFileName}");

        }

        //Provider Congiguration
       
    }
}
