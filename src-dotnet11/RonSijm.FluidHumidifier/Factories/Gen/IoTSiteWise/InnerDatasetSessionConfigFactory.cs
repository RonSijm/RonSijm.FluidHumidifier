// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerDatasetSessionConfigFactory(Action<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.DatasetTypes.SessionConfig>
{

    protected override Humidifier.IoTSiteWise.DatasetTypes.SessionConfig Create()
    {
        var sessionConfigResult = CreateSessionConfig();
        factoryAction?.Invoke(sessionConfigResult);

        return sessionConfigResult;
    }

    private Humidifier.IoTSiteWise.DatasetTypes.SessionConfig CreateSessionConfig()
    {
        var sessionConfigResult = new Humidifier.IoTSiteWise.DatasetTypes.SessionConfig();

        return sessionConfigResult;
    }

} // End Of Class

public static class InnerDatasetSessionConfigFactoryExtensions
{
}
