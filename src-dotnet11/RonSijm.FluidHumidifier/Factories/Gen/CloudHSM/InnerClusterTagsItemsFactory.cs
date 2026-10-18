// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudHSM;

public class InnerClusterTagsItemsFactory(Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CloudHSM.ClusterTypes.TagsItems>
{

    protected override Humidifier.CloudHSM.ClusterTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CloudHSM.ClusterTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CloudHSM.ClusterTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerClusterTagsItemsFactoryExtensions
{
}
