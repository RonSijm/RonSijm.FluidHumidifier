// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerThreatIntelSetTagItemFactory(Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem>
{

    protected override Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerThreatIntelSetTagItemFactoryExtensions
{
}
