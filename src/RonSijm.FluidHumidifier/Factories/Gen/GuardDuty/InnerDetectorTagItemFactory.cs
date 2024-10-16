// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerDetectorTagItemFactory(Action<Humidifier.GuardDuty.DetectorTypes.TagItem> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.DetectorTypes.TagItem>
{

    protected override Humidifier.GuardDuty.DetectorTypes.TagItem Create()
    {
        var tagItemResult = CreateTagItem();
        factoryAction?.Invoke(tagItemResult);

        return tagItemResult;
    }

    private Humidifier.GuardDuty.DetectorTypes.TagItem CreateTagItem()
    {
        var tagItemResult = new Humidifier.GuardDuty.DetectorTypes.TagItem();

        return tagItemResult;
    }

} // End Of Class

public static class InnerDetectorTagItemFactoryExtensions
{
}
