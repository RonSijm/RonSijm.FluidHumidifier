// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class ChannelGroupFactory(string resourceName = null, Action<Humidifier.MediaPackageV2.ChannelGroup> factoryAction = null) : ResourceFactory<Humidifier.MediaPackageV2.ChannelGroup>(resourceName)
{

    protected override Humidifier.MediaPackageV2.ChannelGroup Create()
    {
        var channelGroupResult = CreateChannelGroup();
        factoryAction?.Invoke(channelGroupResult);

        return channelGroupResult;
    }

    private Humidifier.MediaPackageV2.ChannelGroup CreateChannelGroup()
    {
        var channelGroupResult = new Humidifier.MediaPackageV2.ChannelGroup
        {
            GivenName = InputResourceName,
        };

        return channelGroupResult;
    }

} // End Of Class

public static class ChannelGroupFactoryExtensions
{
}
