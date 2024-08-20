using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Update;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure.Internal;
using Pomelo.EntityFrameworkCore.MySql.Migrations;

namespace Len.EntityFrameworkCore.MySql;

internal sealed class MigrationsSqlGenerator(MigrationsSqlGeneratorDependencies dependencies, ICommandBatchPreparer commandBatchPreparer, IMySqlOptions options)
    : MySqlMigrationsSqlGenerator(dependencies, commandBatchPreparer, options)
{
    protected override void Generate(CreateTableOperation operation, IModel model, MigrationCommandListBuilder builder, bool terminate = true)
    {
        operation.ForeignKeys.Clear();
        base.Generate(operation, model, builder, terminate);
    }
}
