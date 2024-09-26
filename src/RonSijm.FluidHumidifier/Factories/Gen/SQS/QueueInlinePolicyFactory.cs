// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SQS;

public class QueueInlinePolicyFactory(string resourceName = null, Action<Humidifier.SQS.QueueInlinePolicy> factoryAction = null) : ResourceFactory<Humidifier.SQS.QueueInlinePolicy>(resourceName)
{

    protected override Humidifier.SQS.QueueInlinePolicy Create()
    {
        var queueInlinePolicyResult = CreateQueueInlinePolicy();
        factoryAction?.Invoke(queueInlinePolicyResult);

        return queueInlinePolicyResult;
    }

    private Humidifier.SQS.QueueInlinePolicy CreateQueueInlinePolicy()
    {
        var queueInlinePolicyResult = new Humidifier.SQS.QueueInlinePolicy
        {
            GivenName = InputResourceName,
        };

        return queueInlinePolicyResult;
    }

} // End Of Class

public static class QueueInlinePolicyFactoryExtensions
{
}
