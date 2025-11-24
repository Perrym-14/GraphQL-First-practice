using Odyssey.MusicMatcher.Types;

namespace Odyssey.MusicMatcher
{
    public class Query
    {
        [GraphQLDescription("Playlist hand-picked to be featured to all users.")]
        public List<Playlist> FeaturedPlaylists()
        {
            return new List<Playlist>
            {
                new("1", "BoomshockaLocka"),
                new("2", "My job gives me the blues"),
                new("3", "Is it five o'clock yet?")
            };
        }
    }
}