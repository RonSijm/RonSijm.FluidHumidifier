// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPrefetchSchedulePrefetchConsumptionFactory(Action<Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchConsumption> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchConsumption>
{

    protected override Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchConsumption Create()
    {
        var prefetchConsumptionResult = CreatePrefetchConsumption();
        factoryAction?.Invoke(prefetchConsumptionResult);

        return prefetchConsumptionResult;
    }

    private Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchConsumption CreatePrefetchConsumption()
    {
        var prefetchConsumptionResult = new Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchConsumption();

        return prefetchConsumptionResult;
    }

} // End Of Class

public static class InnerPrefetchSchedulePrefetchConsumptionFactoryExtensions
{
}
