using SQLite;

namespace AppCommunityBible.Data.Context
{
    public interface IBibleContext
    {
        void Connect(string dbPath);
        SQLiteAsyncConnection Database { get; }
    }
}
