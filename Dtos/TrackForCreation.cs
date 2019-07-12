namespace Waless.API.Dtos
{
    public class TrackForCreation
    {
        public string Id { get; set; }
        public bool Readable { get; set; }
        public string Title { get; set; }
        public string Title_short { get; set; }
        public string Link { get; set; }
        public int Duration { get; set; }
        public string Release_date { get; set; }
        public bool Explicit_lyrics { get; set; }
        public string Preview { get; set; }
        public ArtistForCreation Artist { get; set; }
        public AlbumForCreation Album { get; set; }
        public string Type { get; set; }
    }
}