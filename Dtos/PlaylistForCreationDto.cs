using System;
using System.Collections.Generic;
using Waless.API.Models;

namespace Waless.API.Dtos
{
    public class PlaylistForCreationDto
    {
        public string Title { get; set; }
        public string Picture_medium { get; set; }
        public int CreatorId { get; set; }
        public DateTime Last_updated => DateTime.Now;
        public ICollection<TrackForCreation> Tracks { get; set; }
    }
}