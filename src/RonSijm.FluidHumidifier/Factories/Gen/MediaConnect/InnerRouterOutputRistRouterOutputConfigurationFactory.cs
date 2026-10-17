// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputRistRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.RistRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.RistRouterOutputConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.RistRouterOutputConfiguration Create()
    {
        var ristRouterOutputConfigurationResult = CreateRistRouterOutputConfiguration();
        factoryAction?.Invoke(ristRouterOutputConfigurationResult);

        return ristRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.RistRouterOutputConfiguration CreateRistRouterOutputConfiguration()
    {
        var ristRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.RistRouterOutputConfiguration();

        return ristRouterOutputConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputRistRouterOutputConfigurationFactoryExtensions
{
}
