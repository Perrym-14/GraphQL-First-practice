using System;
using Odyssey.MusicMatcher.Types;

namespace Odyssey.MusicMatcher;
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
    [GraphQLDescription("Collection of individual music tracks.")]
    public List<Track> Tracks { get; set; }

    public Playlist(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public Playlist(SpotifyWeb.PlaylistSimplified simPlaylist)
    {
        Id = simPlaylist.Id;
        Name = simPlaylist.Name;
        Description = simPlaylist.Description;
    }

    public Playlist(SpotifyWeb.Playlist obj) 
    {
        Id = obj.Id;
        Name = obj.Name;
        Description = obj.Description;
        Tracks = [..  obj.Tracks.Items.Select(x => new Track(x.Track))];
    }
}
