// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerComputeQuotaResourceSharingConfigFactory(Action<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig>
{

    protected override Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig Create()
    {
        var resourceSharingConfigResult = CreateResourceSharingConfig();
        factoryAction?.Invoke(resourceSharingConfigResult);

        return resourceSharingConfigResult;
    }

    private Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig CreateResourceSharingConfig()
    {
        var resourceSharingConfigResult = new Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig();

        return resourceSharingConfigResult;
    }

} // End Of Class

public static class InnerComputeQuotaResourceSharingConfigFactoryExtensions
{
}
