// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SQS;

public class QueueFactory(string resourceName = null, Action<Humidifier.SQS.Queue> factoryAction = null) : ResourceFactory<Humidifier.SQS.Queue>(resourceName)
{

    protected override Humidifier.SQS.Queue Create()
    {
        var queueResult = CreateQueue();
        factoryAction?.Invoke(queueResult);

        return queueResult;
    }

    private Humidifier.SQS.Queue CreateQueue()
    {
        var queueResult = new Humidifier.SQS.Queue
        {
            GivenName = InputResourceName,
        };

        return queueResult;
    }

} // End Of Class

public static class QueueFactoryExtensions
{
}
