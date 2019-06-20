using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Waless.API.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        public string Id { get; set; }
        public bool Readable { get; set; }
        public string Title { get; set; }
        public string Title_short { get; set; }
        public string Link { get; set; }
        public int Duration { get; set; }
        public string Release_date { get; set; }
        public bool Explicit_lyrics { get; set; }
        public string Preview { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public string Type { get; set; }
    }
}