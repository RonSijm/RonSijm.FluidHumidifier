// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointRtpStandardDestinationEndpointConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.RtpStandardDestinationEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.RtpStandardDestinationEndpointConfiguration>
{

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.RtpStandardDestinationEndpointConfiguration Create()
    {
        var rtpStandardDestinationEndpointConfigurationResult = CreateRtpStandardDestinationEndpointConfiguration();
        factoryAction?.Invoke(rtpStandardDestinationEndpointConfigurationResult);

        return rtpStandardDestinationEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.RtpStandardDestinationEndpointConfiguration CreateRtpStandardDestinationEndpointConfiguration()
    {
        var rtpStandardDestinationEndpointConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.RtpStandardDestinationEndpointConfiguration();

        return rtpStandardDestinationEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerDestinationEndpointRtpStandardDestinationEndpointConfigurationFactoryExtensions
{
}
