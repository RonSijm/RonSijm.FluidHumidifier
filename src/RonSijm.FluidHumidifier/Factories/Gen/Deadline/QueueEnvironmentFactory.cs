// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class QueueEnvironmentFactory(string resourceName = null, Action<Humidifier.Deadline.QueueEnvironment> factoryAction = null) : ResourceFactory<Humidifier.Deadline.QueueEnvironment>(resourceName)
{

    protected override Humidifier.Deadline.QueueEnvironment Create()
    {
        var queueEnvironmentResult = CreateQueueEnvironment();
        factoryAction?.Invoke(queueEnvironmentResult);

        return queueEnvironmentResult;
    }

    private Humidifier.Deadline.QueueEnvironment CreateQueueEnvironment()
    {
        var queueEnvironmentResult = new Humidifier.Deadline.QueueEnvironment
        {
            GivenName = InputResourceName,
        };

        return queueEnvironmentResult;
    }

} // End Of Class

public static class QueueEnvironmentFactoryExtensions
{
}
