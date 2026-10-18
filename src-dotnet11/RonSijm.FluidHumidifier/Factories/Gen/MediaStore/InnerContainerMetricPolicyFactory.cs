// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaStore;

public class InnerContainerMetricPolicyFactory(Action<Humidifier.MediaStore.ContainerTypes.MetricPolicy> factoryAction = null) : SubResourceFactory<Humidifier.MediaStore.ContainerTypes.MetricPolicy>
{

    protected override Humidifier.MediaStore.ContainerTypes.MetricPolicy Create()
    {
        var metricPolicyResult = CreateMetricPolicy();
        factoryAction?.Invoke(metricPolicyResult);

        return metricPolicyResult;
    }

    private Humidifier.MediaStore.ContainerTypes.MetricPolicy CreateMetricPolicy()
    {
        var metricPolicyResult = new Humidifier.MediaStore.ContainerTypes.MetricPolicy();

        return metricPolicyResult;
    }

} // End Of Class

public static class InnerContainerMetricPolicyFactoryExtensions
{
}
