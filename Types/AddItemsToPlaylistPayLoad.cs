using System;

namespace Odyssey.MusicMatcher.Types;

public class AddItemsToPlaylistPayLoad
{
    [GraphQLDescription("Similar to HTTP status code, represents the status of the mutation.")]
    public int Code { get; set; }
    [GraphQLDescription("Indicates if the mutation was succesful.")]
    public bool Success { get; set; }
    [GraphQLDescription("Message containing some context on the mutation's error.")]
    public string Message { get; set; }
    [GraphQLDescription("The playlist that contains the newly added items.")]
    public Playlist? Playlist { get; set; }

    public AddItemsToPlaylistPayLoad(int code, bool sucess, string message, Playlist? playlist)
    {
        Code = code;
        Success = sucess;
        Message = message;
        Playlist = playlist ?? null;
    }
}
