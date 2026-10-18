// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputRtpRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration Create()
    {
        var rtpRouterInputConfigurationResult = CreateRtpRouterInputConfiguration();
        factoryAction?.Invoke(rtpRouterInputConfigurationResult);

        return rtpRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration CreateRtpRouterInputConfiguration()
    {
        var rtpRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration();

        return rtpRouterInputConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputRtpRouterInputConfigurationFactoryExtensions
{
}
