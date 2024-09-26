// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationApplicationMaintenanceConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration Create()
    {
        var applicationMaintenanceConfigurationResult = CreateApplicationMaintenanceConfiguration();
        factoryAction?.Invoke(applicationMaintenanceConfigurationResult);

        return applicationMaintenanceConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration CreateApplicationMaintenanceConfiguration()
    {
        var applicationMaintenanceConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationMaintenanceConfiguration();

        return applicationMaintenanceConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationApplicationMaintenanceConfigurationFactoryExtensions
{
}
