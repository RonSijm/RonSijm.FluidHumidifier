// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexTagsFactory(Action<Humidifier.MediaLive.MultiplexTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexTypes.Tags>
{

    protected override Humidifier.MediaLive.MultiplexTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.MediaLive.MultiplexTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.MediaLive.MultiplexTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerMultiplexTagsFactoryExtensions
{
}
