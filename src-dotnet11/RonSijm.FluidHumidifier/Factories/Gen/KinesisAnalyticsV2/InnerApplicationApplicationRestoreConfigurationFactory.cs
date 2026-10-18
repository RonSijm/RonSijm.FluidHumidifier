// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationApplicationRestoreConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration Create()
    {
        var applicationRestoreConfigurationResult = CreateApplicationRestoreConfiguration();
        factoryAction?.Invoke(applicationRestoreConfigurationResult);

        return applicationRestoreConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration CreateApplicationRestoreConfiguration()
    {
        var applicationRestoreConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationRestoreConfiguration();

        return applicationRestoreConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationApplicationRestoreConfigurationFactoryExtensions
{
}
