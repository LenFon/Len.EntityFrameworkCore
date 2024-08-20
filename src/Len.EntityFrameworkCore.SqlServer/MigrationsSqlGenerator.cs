using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Update;

namespace Len.EntityFrameworkCore.SqlServer;

internal sealed class MigrationsSqlGenerator(MigrationsSqlGeneratorDependencies dependencies, ICommandBatchPreparer commandBatchPreparer) 
    : SqlServerMigrationsSqlGenerator(dependencies, commandBatchPreparer)
{
    protected override void Generate(CreateTableOperation operation, IModel? model, MigrationCommandListBuilder builder, bool terminate = true)
    {
        operation.ForeignKeys.Clear();
        base.Generate(operation, model, builder, terminate);
    }
}
