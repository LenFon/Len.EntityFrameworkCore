using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Len.EntityFrameworkCore;

public static class DbContextOptionsBuilderExtensions
{
    public static DbContextOptionsBuilder UseRemoveForeignKey(this DbContextOptionsBuilder builder, Action<RemoveForeignKeyOptions> action)
    {
        RemoveForeignKeyOptions options = new();
        action.Invoke(options);

        if (options.MigrationsSqlGeneratorType is null)
        {
            return builder;
        }

        builder.Options.WithExtension(builder.Options.GetExtension<CoreOptionsExtension>().WithReplacedService(typeof(IMigrationsSqlGenerator), options.MigrationsSqlGeneratorType));
        return builder;
    }
}