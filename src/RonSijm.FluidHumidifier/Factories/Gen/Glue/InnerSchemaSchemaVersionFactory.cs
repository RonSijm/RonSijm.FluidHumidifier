// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSchemaSchemaVersionFactory(Action<Humidifier.Glue.SchemaTypes.SchemaVersion> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SchemaTypes.SchemaVersion>
{

    protected override Humidifier.Glue.SchemaTypes.SchemaVersion Create()
    {
        var schemaVersionResult = CreateSchemaVersion();
        factoryAction?.Invoke(schemaVersionResult);

        return schemaVersionResult;
    }

    private Humidifier.Glue.SchemaTypes.SchemaVersion CreateSchemaVersion()
    {
        var schemaVersionResult = new Humidifier.Glue.SchemaTypes.SchemaVersion();

        return schemaVersionResult;
    }

} // End Of Class

public static class InnerSchemaSchemaVersionFactoryExtensions
{
}
