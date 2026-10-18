// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerFilterTagItemFactory(Action<Humidifier.GuardDuty.FilterTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.FilterTypes.TagItem>
{

    protected override Humidifier.GuardDuty.FilterTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.FilterTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.FilterTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerFilterTagItemFactoryExtensions
{
}
