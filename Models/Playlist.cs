using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Waless.API.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }
        public string Title { get; set; }
        public long Duration { get; set; }
        public long Nb_tracks { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }
        public string Picture_small { get; set; }
        public string Picture_medium { get; set; }
        public string Picture_big { get; set; }
        public string Picture_xl { get; set; }
        public string Tracklist { get; set; }
        public DateTime Creation_Date { get; set; }
        public User Creator { get; set; }
        public int CreatorId { get; set; }
        public string Type { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}