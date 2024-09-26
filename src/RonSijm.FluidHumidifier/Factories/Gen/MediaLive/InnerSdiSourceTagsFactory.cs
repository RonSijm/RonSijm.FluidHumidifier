// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerSdiSourceTagsFactory(Action<Humidifier.MediaLive.SdiSourceTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.SdiSourceTypes.Tags>
{

    protected override Humidifier.MediaLive.SdiSourceTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.MediaLive.SdiSourceTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.MediaLive.SdiSourceTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerSdiSourceTagsFactoryExtensions
{
}
