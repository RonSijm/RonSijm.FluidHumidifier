// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageMetricsSourceFactory(Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.MetricsSource>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.MetricsSource Create()
    {
        var metricsSourceResult = CreateMetricsSource();
        factoryAction?.Invoke(metricsSourceResult);

        return metricsSourceResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.MetricsSource CreateMetricsSource()
    {
        var metricsSourceResult = new Humidifier.SageMaker.ModelPackageTypes.MetricsSource();

        return metricsSourceResult;
    }

} // End Of Class

public static class InnerModelPackageMetricsSourceFactoryExtensions
{
}
