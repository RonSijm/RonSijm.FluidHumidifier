// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobQueueComputeEnvironmentOrderFactory(Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder>
{

    protected override Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder Create()
    {
        var computeEnvironmentOrderResult = CreateComputeEnvironmentOrder();
        factoryAction?.Invoke(computeEnvironmentOrderResult);

        return computeEnvironmentOrderResult;
    }

    private Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder CreateComputeEnvironmentOrder()
    {
        var computeEnvironmentOrderResult = new Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder();

        return computeEnvironmentOrderResult;
    }

} // End Of Class

public static class InnerJobQueueComputeEnvironmentOrderFactoryExtensions
{
}
