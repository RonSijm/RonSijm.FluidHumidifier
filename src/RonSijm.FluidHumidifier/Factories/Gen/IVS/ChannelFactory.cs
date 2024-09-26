// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class ChannelFactory(string resourceName = null, Action<Humidifier.IVS.Channel> factoryAction = null) : ResourceFactory<Humidifier.IVS.Channel>(resourceName)
{

    protected override Humidifier.IVS.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.IVS.Channel CreateChannel()
    {
        var channelResult = new Humidifier.IVS.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
}
