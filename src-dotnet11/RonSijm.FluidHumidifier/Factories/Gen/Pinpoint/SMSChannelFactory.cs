// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class SMSChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.SMSChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.SMSChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.SMSChannel Create()
    {
        var sMSChannelResult = CreateSMSChannel();
        factoryAction?.Invoke(sMSChannelResult);

        return sMSChannelResult;
    }

    private Humidifier.Pinpoint.SMSChannel CreateSMSChannel()
    {
        var sMSChannelResult = new Humidifier.Pinpoint.SMSChannel
        {
            GivenName = InputResourceName,
        };

        return sMSChannelResult;
    }

} // End Of Class

public static class SMSChannelFactoryExtensions
{
}
