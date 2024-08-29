using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Len.EntityFrameworkCore.SqlServer;

public static class RemoveForeignKeyOptionExtensions
{
    public static SqlServerDbContextOptionsBuilder RemoveForeignKey(this SqlServerDbContextOptionsBuilder options)
    {
        var builder = ((IRelationalDbContextOptionsBuilderInfrastructure)options).OptionsBuilder;
        builder.ReplaceService<IMigrationsSqlGenerator, MigrationsSqlGenerator>();

        return options;
    }
}
