using FluentMigrator;

namespace Serene_Movies_Task.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20221114_1505)]
public class DefaultDB_20221114_1505_MovieTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Movie")
            .WithColumn("MovieId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Title").AsString(200).NotNullable()
            .WithColumn("Description").AsString(1000).Nullable()
            .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
            .WithColumn("Year").AsInt32().Nullable()
            .WithColumn("ReleaseDate").AsDateTime().Nullable()
            .WithColumn("Runtime").AsInt32().Nullable();
    }
}