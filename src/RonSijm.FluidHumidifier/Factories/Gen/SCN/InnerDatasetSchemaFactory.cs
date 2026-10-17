// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDatasetSchemaFactory(Action<Humidifier.SCN.DatasetTypes.Schema> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DatasetTypes.Schema>
{

    protected override Humidifier.SCN.DatasetTypes.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.SCN.DatasetTypes.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.SCN.DatasetTypes.Schema();

        return schemaResult;
    }

} // End Of Class

public static class InnerDatasetSchemaFactoryExtensions
{
}
