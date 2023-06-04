using App.DAL.DataContext;
using App.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly DBTESTContext _dbcontext;
        public GenericRepository(DBTESTContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<TModel>> GetEmployee()
        {
            try
            {
                return await _dbcontext.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
