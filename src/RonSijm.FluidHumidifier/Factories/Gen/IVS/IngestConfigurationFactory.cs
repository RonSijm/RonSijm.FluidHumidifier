// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class IngestConfigurationFactory(string resourceName = null, Action<Humidifier.IVS.IngestConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IVS.IngestConfiguration>(resourceName)
{

    protected override Humidifier.IVS.IngestConfiguration Create()
    {
        var ingestConfigurationResult = CreateIngestConfiguration();
        factoryAction?.Invoke(ingestConfigurationResult);

        return ingestConfigurationResult;
    }

    private Humidifier.IVS.IngestConfiguration CreateIngestConfiguration()
    {
        var ingestConfigurationResult = new Humidifier.IVS.IngestConfiguration
        {
            GivenName = InputResourceName,
        };

        return ingestConfigurationResult;
    }

} // End Of Class

public static class IngestConfigurationFactoryExtensions
{
}
