using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Waless.API.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Cover { get; set; }
        public string Cover_small { get; set; }
        public string Cover_medium { get; set; }
        public string Cover_big { get; set; }
        public string Cover_xl { get; set; }
        public string Release_date { get; set; }
        public string Tracklist { get; set; }
        public string Type { get; set; }
    }
}