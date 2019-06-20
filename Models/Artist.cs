using System.ComponentModel.DataAnnotations;

namespace Waless.API.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string Id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string picture { get; set; }
        public string picture_small { get; set; }
        public string picture_medium { get; set; }
        public string picture_big { get; set; }
        public string picture_xl { get; set; }
        public string tracklist { get; set; }
        public string type { get; set; }
    }
}