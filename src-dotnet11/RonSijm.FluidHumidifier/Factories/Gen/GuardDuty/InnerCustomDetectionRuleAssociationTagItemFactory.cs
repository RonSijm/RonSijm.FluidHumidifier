// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerCustomDetectionRuleAssociationTagItemFactory(Action<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem>
{

    protected override Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.CustomDetectionRuleAssociationTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerCustomDetectionRuleAssociationTagItemFactoryExtensions
{
}
