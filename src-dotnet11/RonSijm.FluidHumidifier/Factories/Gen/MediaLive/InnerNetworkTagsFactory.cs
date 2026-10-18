// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerNetworkTagsFactory(Action<Humidifier.MediaLive.NetworkTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.NetworkTypes.Tags>
{

    protected override Humidifier.MediaLive.NetworkTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.MediaLive.NetworkTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.MediaLive.NetworkTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerNetworkTagsFactoryExtensions
{
}
