// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class IngestionFactory(string resourceName = null, Action<Humidifier.QuickSight.Ingestion> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Ingestion>(resourceName)
{

    protected override Humidifier.QuickSight.Ingestion Create()
    {
        var ingestionResult = CreateIngestion();
        factoryAction?.Invoke(ingestionResult);

        return ingestionResult;
    }

    private Humidifier.QuickSight.Ingestion CreateIngestion()
    {
        var ingestionResult = new Humidifier.QuickSight.Ingestion
        {
            GivenName = InputResourceName,
        };

        return ingestionResult;
    }

} // End Of Class

public static class IngestionFactoryExtensions
{
}
