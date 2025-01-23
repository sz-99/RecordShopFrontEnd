using System.Reflection;

namespace RecordShopFrontEnd
{
    public class AlbumList
    {
        public static List<Album> Albums = new List<Album>()
        {
            new Album() { Id = 1, Name = "30", Artist = "Adele", ReleaseYear = 2021, Genre = Genre.Pop },
            new Album() { Id = 2, Name = "21", Artist = "Adele", ReleaseYear = 2011, Genre = Genre.Pop },
            new Album() { Id = 3, Name = "Hotel California", Artist = "Eagles", ReleaseYear = 1976, Genre = Genre.Country }
        };
    }
}
