// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerWorkerTagsItemsFactory(Action<Humidifier.Deadline.WorkerTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.WorkerTypes.TagsItems>
{

    protected override Humidifier.Deadline.WorkerTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Deadline.WorkerTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Deadline.WorkerTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerWorkerTagsItemsFactoryExtensions
{
}
