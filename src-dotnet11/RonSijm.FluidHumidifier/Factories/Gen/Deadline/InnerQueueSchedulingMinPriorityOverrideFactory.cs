// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueueSchedulingMinPriorityOverrideFactory(Action<Humidifier.Deadline.QueueTypes.SchedulingMinPriorityOverride> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.SchedulingMinPriorityOverride>
{

    protected override Humidifier.Deadline.QueueTypes.SchedulingMinPriorityOverride Create()
    {
        var schedulingMinPriorityOverrideResult = CreateSchedulingMinPriorityOverride();
        factoryAction?.Invoke(schedulingMinPriorityOverrideResult);

        return schedulingMinPriorityOverrideResult;
    }

    private Humidifier.Deadline.QueueTypes.SchedulingMinPriorityOverride CreateSchedulingMinPriorityOverride()
    {
        var schedulingMinPriorityOverrideResult = new Humidifier.Deadline.QueueTypes.SchedulingMinPriorityOverride();

        return schedulingMinPriorityOverrideResult;
    }

} // End Of Class

public static class InnerQueueSchedulingMinPriorityOverrideFactoryExtensions
{
}
