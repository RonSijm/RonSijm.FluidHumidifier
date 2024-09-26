// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisVideo;

public class SignalingChannelFactory(string resourceName = null, Action<Humidifier.KinesisVideo.SignalingChannel> factoryAction = null) : ResourceFactory<Humidifier.KinesisVideo.SignalingChannel>(resourceName)
{

    protected override Humidifier.KinesisVideo.SignalingChannel Create()
    {
        var signalingChannelResult = CreateSignalingChannel();
        factoryAction?.Invoke(signalingChannelResult);

        return signalingChannelResult;
    }

    private Humidifier.KinesisVideo.SignalingChannel CreateSignalingChannel()
    {
        var signalingChannelResult = new Humidifier.KinesisVideo.SignalingChannel
        {
            GivenName = InputResourceName,
        };

        return signalingChannelResult;
    }

} // End Of Class

public static class SignalingChannelFactoryExtensions
{
}
