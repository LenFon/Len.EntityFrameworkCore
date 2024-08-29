using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Len.EntityFrameworkCore.MySql;

public static class RemoveForeignKeyOptionExtensions
{
    public static MySqlDbContextOptionsBuilder RemoveForeignKey(this MySqlDbContextOptionsBuilder options)
    {
        var builder = ((IRelationalDbContextOptionsBuilderInfrastructure)options).OptionsBuilder;
        builder.ReplaceService<IMigrationsSqlGenerator, MigrationsSqlGenerator>();

        return options;
    }
}
