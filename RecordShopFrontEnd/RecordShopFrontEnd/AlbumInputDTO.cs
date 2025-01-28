using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecordShopFrontEnd
{
    public class AlbumInputDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100, ErrorMessage = "Artist Name cannot exceed 100 characters.")]
        [JsonPropertyName("artist")]

        public string Artist { get; set; } = string.Empty;
        [Required]
        [Range(1700, 2050, ErrorMessage = "Please enter valid year.")]
        [JsonPropertyName("releaseYear")]

        public int ReleaseYear { get; set; }
        [EnumDataType(typeof(Genre), ErrorMessage = "Please input valid Genre.")]
        [JsonPropertyName("genre")]

        public Genre Genre { get; set; } = 0;
    }
}
