// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobResourceLimitsFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceLimits> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceLimits>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceLimits Create()
    {
        var resourceLimitsResult = CreateResourceLimits();
        factoryAction?.Invoke(resourceLimitsResult);

        return resourceLimitsResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceLimits CreateResourceLimits()
    {
        var resourceLimitsResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceLimits();

        return resourceLimitsResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobResourceLimitsFactoryExtensions
{
}
