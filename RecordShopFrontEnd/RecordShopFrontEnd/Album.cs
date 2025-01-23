namespace RecordShopFrontEnd
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int ReleaseYear {  get; set; }
        public Genre Genre { get; set; }

    }
    public enum Genre
    {
        Pop,
        Rock,
        Country,
        RnB,
        HipHop,
        Jazz,
        Classic,
        Metal
    }
  
}
