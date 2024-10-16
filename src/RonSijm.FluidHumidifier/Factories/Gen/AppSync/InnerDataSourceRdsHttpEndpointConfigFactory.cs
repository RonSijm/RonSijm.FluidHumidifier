// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceRdsHttpEndpointConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig Create()
    {
        var rdsHttpEndpointConfigResult = CreateRdsHttpEndpointConfig();
        factoryAction?.Invoke(rdsHttpEndpointConfigResult);

        return rdsHttpEndpointConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig CreateRdsHttpEndpointConfig()
    {
        var rdsHttpEndpointConfigResult = new Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig();

        return rdsHttpEndpointConfigResult;
    }

} // End Of Class

public static class InnerDataSourceRdsHttpEndpointConfigFactoryExtensions
{
}
