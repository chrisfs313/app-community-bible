using AppCommunityBible.Data.Context;
using AppCommunityBible.Models.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCommunityBible.Data.Repositories
{
    public class BibleRepository : IBibleRepository
    { 
    
        private IBibleContext _context;

        public BibleRepository(IBibleContext context)
        {
            _context = context;
            _context.Connect("rvr1960.sqlite");

            _context.Database.CreateTableAsync<Book>().Wait();
        }

        public Task<List<Book>> GetBooksAsync()
        {
            return _context.Database.Table<Book>().ToListAsync();
        }
    }
}
