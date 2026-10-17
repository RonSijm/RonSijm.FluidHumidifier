// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPrefetchScheduleRecurringConsumptionFactory(Action<Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringConsumption> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringConsumption>
{

    protected override Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringConsumption Create()
    {
        var recurringConsumptionResult = CreateRecurringConsumption();
        factoryAction?.Invoke(recurringConsumptionResult);

        return recurringConsumptionResult;
    }

    private Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringConsumption CreateRecurringConsumption()
    {
        var recurringConsumptionResult = new Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringConsumption();

        return recurringConsumptionResult;
    }

} // End Of Class

public static class InnerPrefetchScheduleRecurringConsumptionFactoryExtensions
{
}
