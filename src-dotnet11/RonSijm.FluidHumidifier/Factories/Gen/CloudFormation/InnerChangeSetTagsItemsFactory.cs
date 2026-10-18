// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerChangeSetTagsItemsFactory(Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.ChangeSetTypes.TagsItems>
{

    protected override Humidifier.CloudFormation.ChangeSetTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CloudFormation.ChangeSetTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CloudFormation.ChangeSetTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerChangeSetTagsItemsFactoryExtensions
{
}
