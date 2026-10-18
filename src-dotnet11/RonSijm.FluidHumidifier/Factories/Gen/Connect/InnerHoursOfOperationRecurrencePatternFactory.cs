// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationRecurrencePatternFactory(Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern>
{

    protected override Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern Create()
    {
        var recurrencePatternResult = CreateRecurrencePattern();
        factoryAction?.Invoke(recurrencePatternResult);

        return recurrencePatternResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern CreateRecurrencePattern()
    {
        var recurrencePatternResult = new Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern();

        return recurrencePatternResult;
    }

} // End Of Class

public static class InnerHoursOfOperationRecurrencePatternFactoryExtensions
{
}
