using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;

namespace Len.EntityFrameworkCore.PostgreSQL;

public static class RemoveForeignKeyOptionExtensions
{
    public static NpgsqlDbContextOptionsBuilder RemoveForeignKey(this NpgsqlDbContextOptionsBuilder options)
    {
        var builder = ((IRelationalDbContextOptionsBuilderInfrastructure)options).OptionsBuilder;
        builder.ReplaceService<IMigrationsSqlGenerator, MigrationsSqlGenerator>();

        return options;
    }
}