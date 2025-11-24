using System;

namespace Odyssey.MusicMatcher.Types;
[GraphQLDescription("A curated collection of tracks designed for a specifc mood or activity.")]
public class Playlist
{
    [GraphQLDescription("The ID for the playlist")]
    [ID]
    public string Id { get; }
    [GraphQLDescription("The name of the playlist.")]
    public string Name { get; set; }
    [GraphQLDescription("The text describing what the playlist is.")]
    public string? Description { get; set; }

    public Playlist(string id, string name)
    {
        Id = id;
        Name = name;
    }
}
