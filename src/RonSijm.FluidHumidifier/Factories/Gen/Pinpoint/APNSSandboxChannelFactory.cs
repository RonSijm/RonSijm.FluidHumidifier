// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class APNSSandboxChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.APNSSandboxChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.APNSSandboxChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.APNSSandboxChannel Create()
    {
        var aPNSSandboxChannelResult = CreateAPNSSandboxChannel();
        factoryAction?.Invoke(aPNSSandboxChannelResult);

        return aPNSSandboxChannelResult;
    }

    private Humidifier.Pinpoint.APNSSandboxChannel CreateAPNSSandboxChannel()
    {
        var aPNSSandboxChannelResult = new Humidifier.Pinpoint.APNSSandboxChannel
        {
            GivenName = InputResourceName,
        };

        return aPNSSandboxChannelResult;
    }

} // End Of Class

public static class APNSSandboxChannelFactoryExtensions
{
}
