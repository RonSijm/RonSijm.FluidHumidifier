// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelPlacementGroupTagsFactory(Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags>
{

    protected override Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerChannelPlacementGroupTagsFactoryExtensions
{
}
