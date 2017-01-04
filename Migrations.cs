using Orchard.Data.Migration;

namespace Urbanit.GoogleAnalytics
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable(name: "SettingsRecord", table: table => table
               .Column<int>(columnName: "Id", column: column => column.PrimaryKey().Identity())
               .Column<bool>(columnName: "Enable", column: column => column.NotNull().WithDefault(false))
               .Column<string>(columnName: "Script", column: column => column.NotNull().Unlimited().WithDefault(""))
            );
            return 1;
        }
    }
}