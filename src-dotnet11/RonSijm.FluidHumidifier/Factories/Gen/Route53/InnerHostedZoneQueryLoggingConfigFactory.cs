// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHostedZoneQueryLoggingConfigFactory(Action<Humidifier.Route53.HostedZoneTypes.QueryLoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HostedZoneTypes.QueryLoggingConfig>
{

    protected override Humidifier.Route53.HostedZoneTypes.QueryLoggingConfig Create()
    {
        var queryLoggingConfigResult = CreateQueryLoggingConfig();
        factoryAction?.Invoke(queryLoggingConfigResult);

        return queryLoggingConfigResult;
    }

    private Humidifier.Route53.HostedZoneTypes.QueryLoggingConfig CreateQueryLoggingConfig()
    {
        var queryLoggingConfigResult = new Humidifier.Route53.HostedZoneTypes.QueryLoggingConfig();

        return queryLoggingConfigResult;
    }

} // End Of Class

public static class InnerHostedZoneQueryLoggingConfigFactoryExtensions
{
}
