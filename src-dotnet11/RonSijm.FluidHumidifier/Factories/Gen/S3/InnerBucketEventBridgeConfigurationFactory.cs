// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketEventBridgeConfigurationFactory(Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.EventBridgeConfiguration>
{

    protected override Humidifier.S3.BucketTypes.EventBridgeConfiguration Create()
    {
        var eventBridgeConfigurationResult = CreateEventBridgeConfiguration();
        factoryAction?.Invoke(eventBridgeConfigurationResult);

        return eventBridgeConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.EventBridgeConfiguration CreateEventBridgeConfiguration()
    {
        var eventBridgeConfigurationResult = new Humidifier.S3.BucketTypes.EventBridgeConfiguration();

        return eventBridgeConfigurationResult;
    }

} // End Of Class

public static class InnerBucketEventBridgeConfigurationFactoryExtensions
{
}
