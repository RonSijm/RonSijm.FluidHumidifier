// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerVolumeTagsItemsFactory(Action<Humidifier.Deadline.VolumeTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.VolumeTypes.TagsItems>
{

    protected override Humidifier.Deadline.VolumeTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Deadline.VolumeTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Deadline.VolumeTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerVolumeTagsItemsFactoryExtensions
{
}
