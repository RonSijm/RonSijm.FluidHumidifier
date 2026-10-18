// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupMetricsCollectionFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection Create()
    {
        var metricsCollectionResult = CreateMetricsCollection();
        factoryAction?.Invoke(metricsCollectionResult);

        return metricsCollectionResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection CreateMetricsCollection()
    {
        var metricsCollectionResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection();

        return metricsCollectionResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupMetricsCollectionFactoryExtensions
{
}
