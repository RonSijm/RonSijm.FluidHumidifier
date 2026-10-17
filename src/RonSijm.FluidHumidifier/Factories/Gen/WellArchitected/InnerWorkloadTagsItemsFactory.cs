// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class InnerWorkloadTagsItemsFactory(Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.WellArchitected.WorkloadTypes.TagsItems>
{

    protected override Humidifier.WellArchitected.WorkloadTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.WellArchitected.WorkloadTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.WellArchitected.WorkloadTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerWorkloadTagsItemsFactoryExtensions
{
}
