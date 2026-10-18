// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class GCMChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.GCMChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.GCMChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.GCMChannel Create()
    {
        var gCMChannelResult = CreateGCMChannel();
        factoryAction?.Invoke(gCMChannelResult);

        return gCMChannelResult;
    }

    private Humidifier.Pinpoint.GCMChannel CreateGCMChannel()
    {
        var gCMChannelResult = new Humidifier.Pinpoint.GCMChannel
        {
            GivenName = InputResourceName,
        };

        return gCMChannelResult;
    }

} // End Of Class

public static class GCMChannelFactoryExtensions
{
}
