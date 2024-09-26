// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class QueueFactory(string resourceName = null, Action<Humidifier.MediaConvert.Queue> factoryAction = null) : ResourceFactory<Humidifier.MediaConvert.Queue>(resourceName)
{

    protected override Humidifier.MediaConvert.Queue Create()
    {
        var queueResult = CreateQueue();
        factoryAction?.Invoke(queueResult);

        return queueResult;
    }

    private Humidifier.MediaConvert.Queue CreateQueue()
    {
        var queueResult = new Humidifier.MediaConvert.Queue
        {
            GivenName = InputResourceName,
        };

        return queueResult;
    }

} // End Of Class

public static class QueueFactoryExtensions
{
}
