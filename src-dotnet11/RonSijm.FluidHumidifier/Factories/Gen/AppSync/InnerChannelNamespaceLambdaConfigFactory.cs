// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerChannelNamespaceLambdaConfigFactory(Action<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig>
{

    protected override Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig Create()
    {
        var lambdaConfigResult = CreateLambdaConfig();
        factoryAction?.Invoke(lambdaConfigResult);

        return lambdaConfigResult;
    }

    private Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig CreateLambdaConfig()
    {
        var lambdaConfigResult = new Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig();

        return lambdaConfigResult;
    }

} // End Of Class

public static class InnerChannelNamespaceLambdaConfigFactoryExtensions
{
}
