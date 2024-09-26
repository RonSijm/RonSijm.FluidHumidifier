// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerTrailEventSelectorFactory(Action<Humidifier.CloudTrail.TrailTypes.EventSelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.TrailTypes.EventSelector>
{

    protected override Humidifier.CloudTrail.TrailTypes.EventSelector Create()
    {
        var eventSelectorResult = CreateEventSelector();
        factoryAction?.Invoke(eventSelectorResult);

        return eventSelectorResult;
    }

    private Humidifier.CloudTrail.TrailTypes.EventSelector CreateEventSelector()
    {
        var eventSelectorResult = new Humidifier.CloudTrail.TrailTypes.EventSelector();

        return eventSelectorResult;
    }

} // End Of Class

public static class InnerTrailEventSelectorFactoryExtensions
{
}
