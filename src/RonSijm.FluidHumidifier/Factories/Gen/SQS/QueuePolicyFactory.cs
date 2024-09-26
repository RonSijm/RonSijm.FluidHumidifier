// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SQS;

public class QueuePolicyFactory(string resourceName = null, Action<Humidifier.SQS.QueuePolicy> factoryAction = null) : ResourceFactory<Humidifier.SQS.QueuePolicy>(resourceName)
{

    protected override Humidifier.SQS.QueuePolicy Create()
    {
        var queuePolicyResult = CreateQueuePolicy();
        factoryAction?.Invoke(queuePolicyResult);

        return queuePolicyResult;
    }

    private Humidifier.SQS.QueuePolicy CreateQueuePolicy()
    {
        var queuePolicyResult = new Humidifier.SQS.QueuePolicy
        {
            GivenName = InputResourceName,
        };

        return queuePolicyResult;
    }

} // End Of Class

public static class QueuePolicyFactoryExtensions
{
}
