// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class QueryLoggingConfigFactory(string resourceName = null, Action<Humidifier.Route53.QueryLoggingConfig> factoryAction = null) : ResourceFactory<Humidifier.Route53.QueryLoggingConfig>(resourceName)
{

    protected override Humidifier.Route53.QueryLoggingConfig Create()
    {
        var queryLoggingConfigResult = CreateQueryLoggingConfig();
        factoryAction?.Invoke(queryLoggingConfigResult);

        return queryLoggingConfigResult;
    }

    private Humidifier.Route53.QueryLoggingConfig CreateQueryLoggingConfig()
    {
        var queryLoggingConfigResult = new Humidifier.Route53.QueryLoggingConfig
        {
            GivenName = InputResourceName,
        };

        return queryLoggingConfigResult;
    }

} // End Of Class

public static class QueryLoggingConfigFactoryExtensions
{
}
