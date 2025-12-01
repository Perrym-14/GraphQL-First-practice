using System;

namespace Odyssey.MusicMatcher.Types;

public class Mutation
{
    [GraphQLDescription("Add one or more items to a user's playlist.")]
    public AddItemsToPlaylistPayLoad AddItemsToPlaylist()
    {
        //Hard-code to hook up and test. Will refactor later.
        return new AddItemsToPlaylistPayLoad(
            200,
            true,
            "Successfully added items to playlist.",
            new Playlist("6Fl8d6KF0O4V5kFdbzalfW", "Sweet Beats & Eats")
        );
    }
}
