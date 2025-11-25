using SpotifyWeb;

namespace Odyssey.MusicMatcher
{
    public class Query
    {
        [GraphQLDescription("Playlist hand-picked to be featured to all users.")]
        public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
        {
            var response = await spotifyService.GetFeaturedPlaylistsAsync();
            return [.. response.Playlists.Items.Select(x => new Playlist(x))];
        }

        [GraphQLDescription("Gets a specific playlist by Id.")]
            public async Task<Playlist?> GetPlaylist([ID] string id, SpotifyService spotifyService)
        {
            var response = await spotifyService.GetPlaylistAsync(id);
            return new Playlist(response);
        }
    }
    
}