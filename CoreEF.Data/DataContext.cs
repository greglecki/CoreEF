using System;
using CoreEF.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CoreEF.Data
{
    public class DataContext: DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
            
        }

        public DbSet<Example> example { get; set; }
    }
}
