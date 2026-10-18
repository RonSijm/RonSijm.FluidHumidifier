// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerPublishingDestinationTagItemFactory(Action<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem>
{

    protected override Humidifier.GuardDuty.PublishingDestinationTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.PublishingDestinationTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.PublishingDestinationTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerPublishingDestinationTagItemFactoryExtensions
{
}
