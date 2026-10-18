// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerPartitionSchemaIdFactory(Action<Humidifier.Glue.PartitionTypes.SchemaId> factoryAction = null) : SubResourceFactory<Humidifier.Glue.PartitionTypes.SchemaId>
{

    protected override Humidifier.Glue.PartitionTypes.SchemaId Create()
    {
        var schemaIdResult = CreateSchemaId();
        factoryAction?.Invoke(schemaIdResult);

        return schemaIdResult;
    }

    private Humidifier.Glue.PartitionTypes.SchemaId CreateSchemaId()
    {
        var schemaIdResult = new Humidifier.Glue.PartitionTypes.SchemaId();

        return schemaIdResult;
    }

} // End Of Class

public static class InnerPartitionSchemaIdFactoryExtensions
{
}
