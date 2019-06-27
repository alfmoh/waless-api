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
        public long Duration
        {
            get
            {
                var totalDuration = 0;
                foreach (var track in Tracks)
                {
                    totalDuration += track.Duration;
                }
                return totalDuration;
            }
        }
        public long Nb_tracks => Tracks.Count;
        public string Picture_medium { get; set; }
        public DateTime Last_updated {get; set;}
        public User Creator { get; set; }
        public int CreatorId { get; set; }
        public string Type => "playlist";
        public ICollection<Track> Tracks { get; set; }
    }
}