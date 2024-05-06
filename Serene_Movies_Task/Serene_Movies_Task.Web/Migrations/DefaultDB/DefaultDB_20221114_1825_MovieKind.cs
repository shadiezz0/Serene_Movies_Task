using FluentMigrator;

namespace Serene_Movies_Task.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20221114_1825)]
public class DefaultDB_20221114_1825_MovieKind : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Movie")
            .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
    }
}