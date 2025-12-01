using System;

namespace Odyssey.MusicMatcher.Types;

public class AddItemToPlaylistInput
{
    [GraphQLDescription("Represents the id of the playlist.")]
    [ID]
    public string PlaylistId { get; set; }
    [GraphQLDescription("Represents the position in the collection.")]
    public int? Index { get; set; }
    [GraphQLDescription("A comma-separated list of Spotify URIs to add.")]
    public List<string> Uris { get; set; }
    
    public AddItemToPlaylistInput(string playlistId, List<string> uris) 
    {
        PlaylistId = playlistId;
        Uris = uris;
    }
}
