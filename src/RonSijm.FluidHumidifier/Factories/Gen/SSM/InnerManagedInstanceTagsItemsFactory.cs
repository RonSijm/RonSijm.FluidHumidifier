// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerManagedInstanceTagsItemsFactory(Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.SSM.ManagedInstanceTypes.TagsItems>
{

    protected override Humidifier.SSM.ManagedInstanceTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.SSM.ManagedInstanceTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.SSM.ManagedInstanceTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerManagedInstanceTagsItemsFactoryExtensions
{
}
