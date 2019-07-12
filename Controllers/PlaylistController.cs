using System;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Waless.API.Data;
using Waless.API.Dtos;
using Waless.API.Models;

namespace Waless.API.Controllers
{

    [Route("api/users/{userId}/[controller]")]
    [Authorize]
    public class PlaylistController : Controller
    {
        private readonly IWalessRepository _repo;
        private readonly IMapper _mapper;
        public PlaylistController(IWalessRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetPlaylist")]
        public async Task<IActionResult> Playlist(int userId, int id)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();
            var playlist = await _repo.GetPlaylist(userId, id);
            var playlistToReturn = _mapper.Map<PlaylistToReturn>(playlist);
            if (playlist == null) return NotFound();
            return Ok(playlistToReturn);
        }

        [HttpGet]
        public async Task<IActionResult> Playlist(int userId)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();
            var playlists = await _repo.GetPlaylists(userId);
            if (playlists == null) return NotFound();
            return Ok(playlists);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlaylist(int userId, [FromBody] PlaylistForCreationDto playlistForCreationDto)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();

            var creator = await _repo.GetUser(userId);
            if (creator == null) return NotFound("User not found");
            playlistForCreationDto.CreatorId = userId;

            var playlist = _mapper.Map<Playlist>(playlistForCreationDto);
            _repo.Add(playlist);

            if (await _repo.SaveAll())
            {
                var returnPlaylist = _mapper.Map<PlaylistToReturn>(playlist);
                return CreatedAtRoute("GetPlaylist", new { id = playlist.PlaylistId }, returnPlaylist);
            }

            throw new Exception("Creating of playlist failed on save");
        }

        [HttpPost("{playlistId}")]
        public async Task<IActionResult> UpdatePlaylist(int userId, int playlistId, [FromBody] TrackForCreation trackForCreation)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();
            var track = _mapper.Map<Track>(trackForCreation);
            var playlist = await _repo.AddToPlaylist(userId, playlistId, track);
            playlist.Last_updated = DateTime.Now;

            if (await _repo.SaveAll())
                return CreatedAtRoute("GetPlaylist", new { id = playlist.PlaylistId }, playlist);

            throw new Exception("Updating of playlist failed on save");
        }

        [HttpDelete("{playlistId}")]
        public async Task<IActionResult> DeletePlaylist(int userId, int playlistId)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();
            var playlist = await _repo.GetPlaylist(userId, playlistId);
            if (playlist == null) return NotFound("Playlist not found");
            _repo.Delete(playlist);
            if (await _repo.SaveAll())
                return NoContent();
            throw new Exception("Error deleting the message");
        }
    }
}