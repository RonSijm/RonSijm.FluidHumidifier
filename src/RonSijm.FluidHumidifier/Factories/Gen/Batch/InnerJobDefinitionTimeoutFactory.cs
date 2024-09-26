// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionTimeoutFactory(Action<Humidifier.Batch.JobDefinitionTypes.Timeout> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.Timeout>
{

    protected override Humidifier.Batch.JobDefinitionTypes.Timeout Create()
    {
        var timeoutResult = CreateTimeout();
        factoryAction?.Invoke(timeoutResult);

        return timeoutResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.Timeout CreateTimeout()
    {
        var timeoutResult = new Humidifier.Batch.JobDefinitionTypes.Timeout();

        return timeoutResult;
    }

} // End Of Class

public static class InnerJobDefinitionTimeoutFactoryExtensions
{
}
