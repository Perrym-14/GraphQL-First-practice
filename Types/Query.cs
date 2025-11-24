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
    }
}