// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class EmailChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.EmailChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.EmailChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.EmailChannel Create()
    {
        var emailChannelResult = CreateEmailChannel();
        factoryAction?.Invoke(emailChannelResult);

        return emailChannelResult;
    }

    private Humidifier.Pinpoint.EmailChannel CreateEmailChannel()
    {
        var emailChannelResult = new Humidifier.Pinpoint.EmailChannel
        {
            GivenName = InputResourceName,
        };

        return emailChannelResult;
    }

} // End Of Class

public static class EmailChannelFactoryExtensions
{
}
