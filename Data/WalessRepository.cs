using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Waless.API.Helpers;
using Waless.API.Models;

namespace Waless.API.Data
{
    public class WalessRepository : IWalessRepository
    {
        private readonly DataContext _context;
        public WalessRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Track> GetTrack(int id)
        {
            return await _context.Tracks.FirstOrDefaultAsync(x => x.TrackId == id);
        }
        public async Task<Album> GetAlbum(int id)
        {
            return await _context.Albums.FirstOrDefaultAsync(x => x.AlbumId == id);
        }

        public async Task<Playlist> GetPlaylist(int userId, int id)
        {
            return await _context.Playlists
            .Include(x => x.Tracks)
                .ThenInclude(x => x.Artist)
            .Include(x => x.Tracks)
                .ThenInclude(x => x.Album)
            .FirstOrDefaultAsync(x => x.PlaylistId == id && x.Creator.Id == userId);
        }

        public async Task<IEnumerable<Playlist>> GetPlaylists(int userId)
        {
            return await _context.Playlists
            .Include(x => x.Tracks)
                .ThenInclude(x => x.Artist)
            .Include(x => x.Tracks)
                .ThenInclude(x => x.Album)
            .Where(x => x.Creator.Id == userId).ToListAsync();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<User> GetUser(int userId)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}