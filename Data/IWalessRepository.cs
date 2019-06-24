using System.Collections.Generic;
using System.Threading.Tasks;
using Waless.API.Models;

namespace Waless.API.Data
{
    public interface IWalessRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<Playlist> AddToPlaylist(int userId, int playlistId, Track track);
        Task<Playlist> GetPlaylist(int id, int userId);
        Task<IEnumerable<Playlist>> GetPlaylists(int userId);
        Task<User> GetUser(int userId);
        Task<bool> SaveAll();
    }
}