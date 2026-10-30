// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointRtpStandardSourceEndpointConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.RtpStandardSourceEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.RtpStandardSourceEndpointConfiguration>
{

    protected override Humidifier.MediaConnect.SourceEndpointTypes.RtpStandardSourceEndpointConfiguration Create()
    {
        var rtpStandardSourceEndpointConfigurationResult = CreateRtpStandardSourceEndpointConfiguration();
        factoryAction?.Invoke(rtpStandardSourceEndpointConfigurationResult);

        return rtpStandardSourceEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.RtpStandardSourceEndpointConfiguration CreateRtpStandardSourceEndpointConfiguration()
    {
        var rtpStandardSourceEndpointConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.RtpStandardSourceEndpointConfiguration();

        return rtpStandardSourceEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerSourceEndpointRtpStandardSourceEndpointConfigurationFactoryExtensions
{
}
