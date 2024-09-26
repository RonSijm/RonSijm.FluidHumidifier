// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class ChannelFactory(string resourceName = null, Action<Humidifier.MediaPackageV2.Channel> factoryAction = null) : ResourceFactory<Humidifier.MediaPackageV2.Channel>(resourceName)
{

    protected override Humidifier.MediaPackageV2.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.MediaPackageV2.Channel CreateChannel()
    {
        var channelResult = new Humidifier.MediaPackageV2.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
}
