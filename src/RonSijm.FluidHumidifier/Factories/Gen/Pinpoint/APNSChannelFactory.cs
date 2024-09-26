// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class APNSChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.APNSChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.APNSChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.APNSChannel Create()
    {
        var aPNSChannelResult = CreateAPNSChannel();
        factoryAction?.Invoke(aPNSChannelResult);

        return aPNSChannelResult;
    }

    private Humidifier.Pinpoint.APNSChannel CreateAPNSChannel()
    {
        var aPNSChannelResult = new Humidifier.Pinpoint.APNSChannel
        {
            GivenName = InputResourceName,
        };

        return aPNSChannelResult;
    }

} // End Of Class

public static class APNSChannelFactoryExtensions
{
}
