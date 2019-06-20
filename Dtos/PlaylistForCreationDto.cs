using System;
using System.Collections.Generic;
using Waless.API.Models;

namespace Waless.API.Dtos
{
    public class PlaylistForCreationDto
    {
        public string Title { get; set; }
        public long Duration { get; set; }
        public long Nb_Tracks { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }
        public string Picture_Small { get; set; }
        public string Picture_Medium { get; set; }
        public string Picture_Big { get; set; }
        public string Picture_Xl { get; set; }
        public string Tracklist { get; set; }
        public DateTime Creation_Date { get; set; }
        public int CreatorId { get; set; }
        public string Type { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}