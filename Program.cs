using Odyssey.MusicMatcher;
using Odyssey.MusicMatcher.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Playlist>()
    .AddType<Artist>();
builder.Services
    .AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder
                .WithOrigins("https://studio.apollographql.com")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    });
var app = builder.Build();
app.UseCors();

app.MapGraphQL();
app.Run();
