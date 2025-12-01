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

    public async Task<List<Track>> Tracks(SpotifyWeb.SpotifyService spotifyService, [Parent] Playlist parent)
    {
        if (_tracks != null)
        {
            return _tracks;
        }

        else
        {
            var response = await spotifyService.GetPlaylistsTracksAsync(parent.Id);
            return [..  response.Items.Select(x => new Track(x.Track))];
        }
    }
    private List<Track>? _tracks;

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

        //Could call endpoint here but if we did, then we would ALWAYS call the endpoint to get full information, even if we don't want to.
    }

    public Playlist(SpotifyWeb.Playlist obj) 
    {
        Id = obj.Id;
        Name = obj.Name;
        Description = obj.Description;
        _tracks = [..  obj.Tracks.Items.Select(x => new Track(x.Track))];
    }
}
