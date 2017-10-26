using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoreEF.Data.Interfaces;
using CoreEF.Data.Models;
using CoreEF.Data.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CoreEF.Data.Repositories
{
    public class ExampleRepo: IExampleRepo
    {
        private DataContext _ctx;

        public ExampleRepo(DataContext ctx)
        {
            this._ctx = ctx;
        }

        public async Task<IEnumerable<Example>> getExamples()
        {
            return await _ctx.example.FromSql($"cms.spGet_BrandNames").ToListAsync();

            // Example with parameter
            //return await _ctx.example.FromSql($"spGet_BrandNames {obj1}, {obj2}").ToListAsync();
        }

        public async Task<int> insert(ExampleVM vm)
        {
            return await _ctx.Database.ExecuteSqlCommandAsync($"cms.spInsertSomething {vm.Name}");
        }
    }
}
