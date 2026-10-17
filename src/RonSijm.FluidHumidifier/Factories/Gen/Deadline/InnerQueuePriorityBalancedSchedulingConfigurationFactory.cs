// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueuePriorityBalancedSchedulingConfigurationFactory(Action<Humidifier.Deadline.QueueTypes.PriorityBalancedSchedulingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.PriorityBalancedSchedulingConfiguration>
{

    protected override Humidifier.Deadline.QueueTypes.PriorityBalancedSchedulingConfiguration Create()
    {
        var priorityBalancedSchedulingConfigurationResult = CreatePriorityBalancedSchedulingConfiguration();
        factoryAction?.Invoke(priorityBalancedSchedulingConfigurationResult);

        return priorityBalancedSchedulingConfigurationResult;
    }

    private Humidifier.Deadline.QueueTypes.PriorityBalancedSchedulingConfiguration CreatePriorityBalancedSchedulingConfiguration()
    {
        var priorityBalancedSchedulingConfigurationResult = new Humidifier.Deadline.QueueTypes.PriorityBalancedSchedulingConfiguration();

        return priorityBalancedSchedulingConfigurationResult;
    }

} // End Of Class

public static class InnerQueuePriorityBalancedSchedulingConfigurationFactoryExtensions
{
}
