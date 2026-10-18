// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSchemaVersionSchemaFactory(Action<Humidifier.Glue.SchemaVersionTypes.Schema> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SchemaVersionTypes.Schema>
{

    protected override Humidifier.Glue.SchemaVersionTypes.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.Glue.SchemaVersionTypes.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.Glue.SchemaVersionTypes.Schema();

        return schemaResult;
    }

} // End Of Class

public static class InnerSchemaVersionSchemaFactoryExtensions
{
}
