// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Forecast;

public class InnerDatasetSchemaFactory(Action<Humidifier.Forecast.DatasetTypes.Schema> factoryAction = null) : SubResourceFactory<Humidifier.Forecast.DatasetTypes.Schema>
{

    protected override Humidifier.Forecast.DatasetTypes.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.Forecast.DatasetTypes.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.Forecast.DatasetTypes.Schema();

        return schemaResult;
    }

} // End Of Class

public static class InnerDatasetSchemaFactoryExtensions
{
}
