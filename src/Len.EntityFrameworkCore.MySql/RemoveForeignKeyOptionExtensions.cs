namespace Len.EntityFrameworkCore.MySql;

public static class RemoveForeignKeyOptionExtensions
{
    public static void MySql(this RemoveForeignKeyOptions options)
    {
        options.MigrationsSqlGeneratorType = typeof(MigrationsSqlGenerator);
    }
}
