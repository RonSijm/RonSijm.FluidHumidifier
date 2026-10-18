// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerClusterTagsFactory(Action<Humidifier.MediaLive.ClusterTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ClusterTypes.Tags>
{

    protected override Humidifier.MediaLive.ClusterTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.MediaLive.ClusterTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.MediaLive.ClusterTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerClusterTagsFactoryExtensions
{
}
