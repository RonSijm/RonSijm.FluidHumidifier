// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthAgent;

public class InnerDomainTagsItemsFactory(Action<Humidifier.HealthAgent.DomainTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.HealthAgent.DomainTypes.TagsItems>
{

    protected override Humidifier.HealthAgent.DomainTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.HealthAgent.DomainTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.HealthAgent.DomainTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerDomainTagsItemsFactoryExtensions
{
}
