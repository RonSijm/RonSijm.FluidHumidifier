// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerGraphQLApiLogConfigFactory(Action<Humidifier.AppSync.GraphQLApiTypes.LogConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.GraphQLApiTypes.LogConfig>
{

    protected override Humidifier.AppSync.GraphQLApiTypes.LogConfig Create()
    {
        var logConfigResult = CreateLogConfig();
        factoryAction?.Invoke(logConfigResult);

        return logConfigResult;
    }

    private Humidifier.AppSync.GraphQLApiTypes.LogConfig CreateLogConfig()
    {
        var logConfigResult = new Humidifier.AppSync.GraphQLApiTypes.LogConfig();

        return logConfigResult;
    }

} // End Of Class

public static class InnerGraphQLApiLogConfigFactoryExtensions
{
}
