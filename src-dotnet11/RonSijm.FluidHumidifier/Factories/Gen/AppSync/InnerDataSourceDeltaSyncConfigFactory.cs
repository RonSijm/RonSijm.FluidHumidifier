// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceDeltaSyncConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig Create()
    {
        var deltaSyncConfigResult = CreateDeltaSyncConfig();
        factoryAction?.Invoke(deltaSyncConfigResult);

        return deltaSyncConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig CreateDeltaSyncConfig()
    {
        var deltaSyncConfigResult = new Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig();

        return deltaSyncConfigResult;
    }

} // End Of Class

public static class InnerDataSourceDeltaSyncConfigFactoryExtensions
{
}
