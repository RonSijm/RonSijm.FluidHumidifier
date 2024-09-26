// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationApplicationSnapshotConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration Create()
    {
        var applicationSnapshotConfigurationResult = CreateApplicationSnapshotConfiguration();
        factoryAction?.Invoke(applicationSnapshotConfigurationResult);

        return applicationSnapshotConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration CreateApplicationSnapshotConfiguration()
    {
        var applicationSnapshotConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationSnapshotConfiguration();

        return applicationSnapshotConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationApplicationSnapshotConfigurationFactoryExtensions
{
}
