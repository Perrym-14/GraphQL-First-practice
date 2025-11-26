using System;
using SpotifyWeb;

namespace Odyssey.MusicMatcher.Types;

[GraphQLDescription("Song in a playlist.")]
public class Track
{
[GraphQLDescription("The Id for the track.")]
public string Id { get; }
[GraphQLDescription("Name of the track.")]
public string Name { get; set; }
//public List<Artist> Artists { get; set; }
[GraphQLDescription("The time duration of the trac in milliseconds.")]
public double DurationMs { get; set; }

[GraphQLDescription("The url link for the track.")]
public string Uri { get; set; }
[GraphQLDescription("Determine if the song is explicit or not.")]
public bool IsExplicit { get; set; }

//public Album Album { get; set; }

public Track(string name, string id, string uri )
{
    Id = id;
    Name = name;
    Uri = uri;
}

public Track(PlaylistTrackItem obj)
{
    Id = obj.Id;
    Name = obj.Name;
    Uri = obj.Uri;
    IsExplicit = obj.Explicit;
    DurationMs = obj.Duration_ms;
}
}
