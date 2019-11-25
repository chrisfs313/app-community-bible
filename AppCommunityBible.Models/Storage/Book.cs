using SQLite;

namespace AppCommunityBible.Models.Storage
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int Testament_Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }
    }
}