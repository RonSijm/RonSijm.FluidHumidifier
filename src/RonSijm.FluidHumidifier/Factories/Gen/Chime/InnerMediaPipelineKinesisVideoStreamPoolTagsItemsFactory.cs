// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaPipelineKinesisVideoStreamPoolTagsItemsFactory(Action<Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.TagsItems>
{

    protected override Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerMediaPipelineKinesisVideoStreamPoolTagsItemsFactoryExtensions
{
}
