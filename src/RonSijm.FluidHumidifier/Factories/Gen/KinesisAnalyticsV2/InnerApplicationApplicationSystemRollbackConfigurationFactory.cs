// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationApplicationSystemRollbackConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration Create()
    {
        var applicationSystemRollbackConfigurationResult = CreateApplicationSystemRollbackConfiguration();
        factoryAction?.Invoke(applicationSystemRollbackConfigurationResult);

        return applicationSystemRollbackConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration CreateApplicationSystemRollbackConfiguration()
    {
        var applicationSystemRollbackConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSystemRollbackConfiguration();

        return applicationSystemRollbackConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationApplicationSystemRollbackConfigurationFactoryExtensions
{
}
