// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class APNSVoipChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.APNSVoipChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.APNSVoipChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.APNSVoipChannel Create()
    {
        var aPNSVoipChannelResult = CreateAPNSVoipChannel();
        factoryAction?.Invoke(aPNSVoipChannelResult);

        return aPNSVoipChannelResult;
    }

    private Humidifier.Pinpoint.APNSVoipChannel CreateAPNSVoipChannel()
    {
        var aPNSVoipChannelResult = new Humidifier.Pinpoint.APNSVoipChannel
        {
            GivenName = InputResourceName,
        };

        return aPNSVoipChannelResult;
    }

} // End Of Class

public static class APNSVoipChannelFactoryExtensions
{
}
