using System;

namespace Odyssey.MusicMatcher.Types;

[GraphQLDescription("Represents the person responsible for the given art work.")]
public class Artist
{   
    [GraphQLDescription("ID for the artist.")]
    [ID]
    public string ID { get;}
    [GraphQLDescription("The name of the artist.")]
    public string Name { get; set; }
    [GraphQLDescription("The amount of people tracking the artist.")]
    public int? Followers { get; set; }
    [GraphQLDescription("Represents the average likeablity of the artist's work.")]
    public float Popularity { get; set; }

    public Artist(string id, string name)
    {
        ID = id;
        Name = name;
    }
}
