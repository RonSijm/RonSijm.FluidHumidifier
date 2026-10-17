// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityScanConfigurationContinuousIntegrationScanConfigurationFactory(Action<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration>
{

    protected override Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration Create()
    {
        var continuousIntegrationScanConfigurationResult = CreateContinuousIntegrationScanConfiguration();
        factoryAction?.Invoke(continuousIntegrationScanConfigurationResult);

        return continuousIntegrationScanConfigurationResult;
    }

    private Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration CreateContinuousIntegrationScanConfiguration()
    {
        var continuousIntegrationScanConfigurationResult = new Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration();

        return continuousIntegrationScanConfigurationResult;
    }

} // End Of Class

public static class InnerCodeSecurityScanConfigurationContinuousIntegrationScanConfigurationFactoryExtensions
{
}
