// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerThreatEntitySetTagItemFactory(Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem>
{

    protected override Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerThreatEntitySetTagItemFactoryExtensions
{
}
