namespace Len.EntityFrameworkCore.PostgreSQL;

public static class RemoveForeignKeyOptionExtensions
{
    public static void Npgsql(this RemoveForeignKeyOptions options)
    {
        options.MigrationsSqlGeneratorType = typeof(MigrationsSqlGenerator);
    }
}