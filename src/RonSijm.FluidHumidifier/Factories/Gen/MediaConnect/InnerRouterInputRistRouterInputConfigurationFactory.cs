// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputRistRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration Create()
    {
        var ristRouterInputConfigurationResult = CreateRistRouterInputConfiguration();
        factoryAction?.Invoke(ristRouterInputConfigurationResult);

        return ristRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration CreateRistRouterInputConfiguration()
    {
        var ristRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration();

        return ristRouterInputConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputRistRouterInputConfigurationFactoryExtensions
{
}
