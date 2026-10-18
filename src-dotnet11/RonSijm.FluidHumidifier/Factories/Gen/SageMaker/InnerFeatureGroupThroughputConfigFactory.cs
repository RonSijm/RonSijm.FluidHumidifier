// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupThroughputConfigFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.ThroughputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.ThroughputConfig>
{

    protected override Humidifier.SageMaker.FeatureGroupTypes.ThroughputConfig Create()
    {
        var throughputConfigResult = CreateThroughputConfig();
        factoryAction?.Invoke(throughputConfigResult);

        return throughputConfigResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.ThroughputConfig CreateThroughputConfig()
    {
        var throughputConfigResult = new Humidifier.SageMaker.FeatureGroupTypes.ThroughputConfig();

        return throughputConfigResult;
    }

} // End Of Class

public static class InnerFeatureGroupThroughputConfigFactoryExtensions
{
}
