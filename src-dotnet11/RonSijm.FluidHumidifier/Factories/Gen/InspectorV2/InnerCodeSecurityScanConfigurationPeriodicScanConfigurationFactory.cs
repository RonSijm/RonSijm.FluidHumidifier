// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityScanConfigurationPeriodicScanConfigurationFactory(Action<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration>
{

    protected override Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration Create()
    {
        var periodicScanConfigurationResult = CreatePeriodicScanConfiguration();
        factoryAction?.Invoke(periodicScanConfigurationResult);

        return periodicScanConfigurationResult;
    }

    private Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration CreatePeriodicScanConfiguration()
    {
        var periodicScanConfigurationResult = new Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration();

        return periodicScanConfigurationResult;
    }

} // End Of Class

public static class InnerCodeSecurityScanConfigurationPeriodicScanConfigurationFactoryExtensions
{
}
