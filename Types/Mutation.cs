using System;
using SpotifyWeb;

namespace Odyssey.MusicMatcher.Types;

public class Mutation
{
    [GraphQLDescription("Add one or more items to a user's playlist.")]
    public async Task<AddItemsToPlaylistPayLoad> AddItemsToPlaylist(AddItemToPlaylistInput tracksInput, SpotifyService spotifyService)
    {
        try
        {
            var snapshotId = await spotifyService.AddTracksToPlaylistAsync(
            tracksInput.PlaylistId,
            tracksInput.Index,
            string.Join(",", tracksInput.Uris)
            );

            var response = await spotifyService.GetPlaylistAsync(tracksInput.PlaylistId);
            var playlist = new Playlist(response);
            //Hard-code to hook up and test. Will refactor later.
            return new AddItemsToPlaylistPayLoad(
                200,
                true,
                "Successfully added items to playlist.",
                playlist
            );
        }
        catch (System.Exception e)
        {
            
            return new AddItemsToPlaylistPayLoad(
                500,
                false,
                e.Message,
                null
            );
        }
    }
}

// 