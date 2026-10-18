// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueueSchedulingMaxPriorityOverrideFactory(Action<Humidifier.Deadline.QueueTypes.SchedulingMaxPriorityOverride> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.SchedulingMaxPriorityOverride>
{

    protected override Humidifier.Deadline.QueueTypes.SchedulingMaxPriorityOverride Create()
    {
        var schedulingMaxPriorityOverrideResult = CreateSchedulingMaxPriorityOverride();
        factoryAction?.Invoke(schedulingMaxPriorityOverrideResult);

        return schedulingMaxPriorityOverrideResult;
    }

    private Humidifier.Deadline.QueueTypes.SchedulingMaxPriorityOverride CreateSchedulingMaxPriorityOverride()
    {
        var schedulingMaxPriorityOverrideResult = new Humidifier.Deadline.QueueTypes.SchedulingMaxPriorityOverride();

        return schedulingMaxPriorityOverrideResult;
    }

} // End Of Class

public static class InnerQueueSchedulingMaxPriorityOverrideFactoryExtensions
{
}
