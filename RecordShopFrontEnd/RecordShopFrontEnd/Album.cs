using System.ComponentModel.DataAnnotations;

namespace RecordShopFrontEnd
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Artist Name cannot exceed 100 characters.")]
        public string Artist { get; set; }
        [Required]
        [Range(1700, 2050, ErrorMessage = "Please enter valid year.")]
        public int ReleaseYear {  get; set; }
        [EnumDataType(typeof(Genre), ErrorMessage = "Please input valid Genre.")]
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
