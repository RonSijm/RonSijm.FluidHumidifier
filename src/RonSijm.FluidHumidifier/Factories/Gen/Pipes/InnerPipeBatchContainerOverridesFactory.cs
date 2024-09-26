// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeBatchContainerOverridesFactory(Action<Humidifier.Pipes.PipeTypes.BatchContainerOverrides> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.BatchContainerOverrides>
{

    protected override Humidifier.Pipes.PipeTypes.BatchContainerOverrides Create()
    {
        var batchContainerOverridesResult = CreateBatchContainerOverrides();
        factoryAction?.Invoke(batchContainerOverridesResult);

        return batchContainerOverridesResult;
    }

    private Humidifier.Pipes.PipeTypes.BatchContainerOverrides CreateBatchContainerOverrides()
    {
        var batchContainerOverridesResult = new Humidifier.Pipes.PipeTypes.BatchContainerOverrides();

        return batchContainerOverridesResult;
    }

} // End Of Class

public static class InnerPipeBatchContainerOverridesFactoryExtensions
{
}
