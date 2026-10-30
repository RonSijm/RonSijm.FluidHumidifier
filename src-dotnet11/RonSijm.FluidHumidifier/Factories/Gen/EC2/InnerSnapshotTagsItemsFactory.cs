// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSnapshotTagsItemsFactory(Action<Humidifier.EC2.SnapshotTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SnapshotTypes.TagsItems>
{

    protected override Humidifier.EC2.SnapshotTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.EC2.SnapshotTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.EC2.SnapshotTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerSnapshotTagsItemsFactoryExtensions
{
}
