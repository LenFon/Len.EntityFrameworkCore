namespace Len.EntityFrameworkCore.SqlServer;

public static class RemoveForeignKeyOptionExtensions
{
    public static void SqlServer(this RemoveForeignKeyOptions options)
    {
        options.MigrationsSqlGeneratorType = typeof(MigrationsSqlGenerator);
    }
}
