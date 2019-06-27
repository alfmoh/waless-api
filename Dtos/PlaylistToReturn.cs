using System;
using System.Collections.Generic;
using Waless.API.Models;

namespace Waless.API.Dtos
{
    public class PlaylistToReturn
    {
        public int PlaylistId { get; set; }
        public string Title { get; set; }
        public long Duration { get; set; }
        public long Nb_tracks { get; set; }
        public string Picture_small { get; set; }
        public string Picture_medium { get; set; }
        public DateTime Last_updated { get; set; }
        public int CreatorId { get; set; }
        public string Type { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}