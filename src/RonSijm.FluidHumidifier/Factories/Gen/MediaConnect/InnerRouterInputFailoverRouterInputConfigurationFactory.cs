// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputFailoverRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration Create()
    {
        var failoverRouterInputConfigurationResult = CreateFailoverRouterInputConfiguration();
        factoryAction?.Invoke(failoverRouterInputConfigurationResult);

        return failoverRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration CreateFailoverRouterInputConfiguration()
    {
        var failoverRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration();

        return failoverRouterInputConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputFailoverRouterInputConfigurationFactoryExtensions
{
}
