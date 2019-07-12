using AutoMapper;
using Waless.API.Dtos;
using Waless.API.Models;

namespace Waless.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PlaylistForCreationDto, Playlist>();
            CreateMap<TrackForCreation, Track>();
            CreateMap<AlbumForCreation, Album>();
            CreateMap<ArtistForCreation, Artist>();
            CreateMap<Playlist, PlaylistToReturn>();
        }
    }
}