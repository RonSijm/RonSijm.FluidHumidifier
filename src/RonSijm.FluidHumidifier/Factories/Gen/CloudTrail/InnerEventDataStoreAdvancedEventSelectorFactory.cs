// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerEventDataStoreAdvancedEventSelectorFactory(Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector>
{

    protected override Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector Create()
    {
        var advancedEventSelectorResult = CreateAdvancedEventSelector();
        factoryAction?.Invoke(advancedEventSelectorResult);

        return advancedEventSelectorResult;
    }

    private Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector CreateAdvancedEventSelector()
    {
        var advancedEventSelectorResult = new Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector();

        return advancedEventSelectorResult;
    }

} // End Of Class

public static class InnerEventDataStoreAdvancedEventSelectorFactoryExtensions
{
}
