// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerTrustedEntitySetTagItemFactory(Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem>
{

    protected override Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerTrustedEntitySetTagItemFactoryExtensions
{
}
