// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCM;

public class InnerScheduledReportDateTimeValueFactory(Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> factoryAction = null) : SubResourceFactory<Humidifier.BCM.ScheduledReportTypes.DateTimeValue>
{

    protected override Humidifier.BCM.ScheduledReportTypes.DateTimeValue Create()
    {
        var dateTimeValueResult = CreateDateTimeValue();
        factoryAction?.Invoke(dateTimeValueResult);

        return dateTimeValueResult;
    }

    private Humidifier.BCM.ScheduledReportTypes.DateTimeValue CreateDateTimeValue()
    {
        var dateTimeValueResult = new Humidifier.BCM.ScheduledReportTypes.DateTimeValue();

        return dateTimeValueResult;
    }

} // End Of Class

public static class InnerScheduledReportDateTimeValueFactoryExtensions
{
}
