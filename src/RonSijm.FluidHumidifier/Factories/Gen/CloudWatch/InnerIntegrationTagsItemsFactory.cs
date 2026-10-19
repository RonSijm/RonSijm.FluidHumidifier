// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerIntegrationTagsItemsFactory(Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.IntegrationTypes.TagsItems>
{

    protected override Humidifier.CloudWatch.IntegrationTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CloudWatch.IntegrationTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CloudWatch.IntegrationTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerIntegrationTagsItemsFactoryExtensions
{
}
