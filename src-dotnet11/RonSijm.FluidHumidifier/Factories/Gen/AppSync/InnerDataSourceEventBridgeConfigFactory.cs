// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceEventBridgeConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.EventBridgeConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.EventBridgeConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.EventBridgeConfig Create()
    {
        var eventBridgeConfigResult = CreateEventBridgeConfig();
        factoryAction?.Invoke(eventBridgeConfigResult);

        return eventBridgeConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.EventBridgeConfig CreateEventBridgeConfig()
    {
        var eventBridgeConfigResult = new Humidifier.AppSync.DataSourceTypes.EventBridgeConfig();

        return eventBridgeConfigResult;
    }

} // End Of Class

public static class InnerDataSourceEventBridgeConfigFactoryExtensions
{
}
