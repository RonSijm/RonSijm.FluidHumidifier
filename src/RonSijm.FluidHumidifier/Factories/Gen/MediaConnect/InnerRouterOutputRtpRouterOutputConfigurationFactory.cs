// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputRtpRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.RtpRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.RtpRouterOutputConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.RtpRouterOutputConfiguration Create()
    {
        var rtpRouterOutputConfigurationResult = CreateRtpRouterOutputConfiguration();
        factoryAction?.Invoke(rtpRouterOutputConfigurationResult);

        return rtpRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.RtpRouterOutputConfiguration CreateRtpRouterOutputConfiguration()
    {
        var rtpRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.RtpRouterOutputConfiguration();

        return rtpRouterOutputConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputRtpRouterOutputConfigurationFactoryExtensions
{
}
