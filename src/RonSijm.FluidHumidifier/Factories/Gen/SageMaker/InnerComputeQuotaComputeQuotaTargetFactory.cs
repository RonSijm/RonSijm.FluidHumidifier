// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerComputeQuotaComputeQuotaTargetFactory(Action<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget>
{

    protected override Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget Create()
    {
        var computeQuotaTargetResult = CreateComputeQuotaTarget();
        factoryAction?.Invoke(computeQuotaTargetResult);

        return computeQuotaTargetResult;
    }

    private Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget CreateComputeQuotaTarget()
    {
        var computeQuotaTargetResult = new Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget();

        return computeQuotaTargetResult;
    }

} // End Of Class

public static class InnerComputeQuotaComputeQuotaTargetFactoryExtensions
{
}
