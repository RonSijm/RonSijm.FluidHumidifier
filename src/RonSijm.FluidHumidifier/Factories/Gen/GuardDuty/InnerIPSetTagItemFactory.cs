// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerIPSetTagItemFactory(Action<Humidifier.GuardDuty.IPSetTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.IPSetTypes.TagItem>
{

    protected override Humidifier.GuardDuty.IPSetTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.IPSetTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.IPSetTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerIPSetTagItemFactoryExtensions
{
}
