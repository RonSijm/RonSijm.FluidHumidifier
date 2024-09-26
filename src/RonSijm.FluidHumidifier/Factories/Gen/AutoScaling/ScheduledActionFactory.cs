// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class ScheduledActionFactory(string resourceName = null, Action<Humidifier.AutoScaling.ScheduledAction> factoryAction = null) : ResourceFactory<Humidifier.AutoScaling.ScheduledAction>(resourceName)
{

    protected override Humidifier.AutoScaling.ScheduledAction Create()
    {
        var scheduledActionResult = CreateScheduledAction();
        factoryAction?.Invoke(scheduledActionResult);

        return scheduledActionResult;
    }

    private Humidifier.AutoScaling.ScheduledAction CreateScheduledAction()
    {
        var scheduledActionResult = new Humidifier.AutoScaling.ScheduledAction
        {
            GivenName = InputResourceName,
        };

        return scheduledActionResult;
    }

} // End Of Class

public static class ScheduledActionFactoryExtensions
{
}
