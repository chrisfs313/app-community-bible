using AppCommunityBible.Models.Storage;
using SQLite;
using System;
using System.IO;

namespace AppCommunityBible.Data.Context
{
    public class BibleContext : IBibleContext
    {
        private SQLiteAsyncConnection _database;

        public SQLiteAsyncConnection Database { get { return _database; } }

        public BibleContext()
        {
        }

        public void Connect(string dbPath)
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(folderPath, dbPath);

            _database = new SQLiteAsyncConnection(path);
        }
    }
}
