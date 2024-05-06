using FluentMigrator;

namespace Serene_Movies_Task.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20221114_1703)]
public class DefaultDB_20221114_1703_MovieData : AutoReversingMigration
{
    public override void Up()
    {
        Insert.IntoTable("Movie")
               .Row(new
               {
                   Title = "The Matrix",
                   Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                   Storyline = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                   Year = 1999,
                   ReleaseDate = new DateTime(1999, 3, 31),
                   Runtime = 136
               });

        Insert.IntoTable("Movie")
            .Row(new
            {
                Title = "Inception",
                Description = "A thief who enters the dreams of others to steal secrets from their subconscious.",
                Storyline = "A thief who enters the dreams of others to steal secrets from their subconscious.",
                Year = 2010,
                ReleaseDate = new DateTime(2010, 7, 16),
                Runtime = 148
            });

        Insert.IntoTable("Movie")
            .Row(new
            {
                Title = "Interstellar",
                Description = "A group of astronauts travel through a wormhole in search of a new habitable planet to save humanity.",
                Storyline = "A group of astronauts travel through a wormhole in search of a new habitable planet to save humanity.",
                Year = 2014,
                ReleaseDate = new DateTime(2014, 11, 7),
                Runtime = 169
            });
    }
}