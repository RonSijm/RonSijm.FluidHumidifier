// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class IngestionFactory(string resourceName = null, Action<Humidifier.AppFabric.Ingestion> factoryAction = null) : ResourceFactory<Humidifier.AppFabric.Ingestion>(resourceName)
{

    protected override Humidifier.AppFabric.Ingestion Create()
    {
        var ingestionResult = CreateIngestion();
        factoryAction?.Invoke(ingestionResult);

        return ingestionResult;
    }

    private Humidifier.AppFabric.Ingestion CreateIngestion()
    {
        var ingestionResult = new Humidifier.AppFabric.Ingestion
        {
            GivenName = InputResourceName,
        };

        return ingestionResult;
    }

} // End Of Class

public static class IngestionFactoryExtensions
{
}
