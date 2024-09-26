// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class APNSVoipSandboxChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.APNSVoipSandboxChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.APNSVoipSandboxChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.APNSVoipSandboxChannel Create()
    {
        var aPNSVoipSandboxChannelResult = CreateAPNSVoipSandboxChannel();
        factoryAction?.Invoke(aPNSVoipSandboxChannelResult);

        return aPNSVoipSandboxChannelResult;
    }

    private Humidifier.Pinpoint.APNSVoipSandboxChannel CreateAPNSVoipSandboxChannel()
    {
        var aPNSVoipSandboxChannelResult = new Humidifier.Pinpoint.APNSVoipSandboxChannel
        {
            GivenName = InputResourceName,
        };

        return aPNSVoipSandboxChannelResult;
    }

} // End Of Class

public static class APNSVoipSandboxChannelFactoryExtensions
{
}
