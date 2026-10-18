// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerTrailAdvancedEventSelectorFactory(Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector>
{

    protected override Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector Create()
    {
        var advancedEventSelectorResult = CreateAdvancedEventSelector();
        factoryAction?.Invoke(advancedEventSelectorResult);

        return advancedEventSelectorResult;
    }

    private Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector CreateAdvancedEventSelector()
    {
        var advancedEventSelectorResult = new Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector();

        return advancedEventSelectorResult;
    }

} // End Of Class

public static class InnerTrailAdvancedEventSelectorFactoryExtensions
{
}
