using AppCommunityBible.Models.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppCommunityBible.Data.Repositories
{
    public interface IBibleRepository
    {
        Task<List<Book>> GetBooksAsync();
    }
}
