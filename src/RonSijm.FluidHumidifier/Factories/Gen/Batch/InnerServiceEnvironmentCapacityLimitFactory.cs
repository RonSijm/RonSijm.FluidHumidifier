// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerServiceEnvironmentCapacityLimitFactory(Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit>
{

    protected override Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit Create()
    {
        var capacityLimitResult = CreateCapacityLimit();
        factoryAction?.Invoke(capacityLimitResult);

        return capacityLimitResult;
    }

    private Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit CreateCapacityLimit()
    {
        var capacityLimitResult = new Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit();

        return capacityLimitResult;
    }

} // End Of Class

public static class InnerServiceEnvironmentCapacityLimitFactoryExtensions
{
}
