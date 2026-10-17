// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobQueueServiceEnvironmentOrderFactory(Action<Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder>
{

    protected override Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder Create()
    {
        var serviceEnvironmentOrderResult = CreateServiceEnvironmentOrder();
        factoryAction?.Invoke(serviceEnvironmentOrderResult);

        return serviceEnvironmentOrderResult;
    }

    private Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder CreateServiceEnvironmentOrder()
    {
        var serviceEnvironmentOrderResult = new Humidifier.Batch.JobQueueTypes.ServiceEnvironmentOrder();

        return serviceEnvironmentOrderResult;
    }

} // End Of Class

public static class InnerJobQueueServiceEnvironmentOrderFactoryExtensions
{
}
