// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobAutotuneFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.Autotune> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.Autotune>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.Autotune Create()
    {
        var autotuneResult = CreateAutotune();
        factoryAction?.Invoke(autotuneResult);

        return autotuneResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.Autotune CreateAutotune()
    {
        var autotuneResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.Autotune();

        return autotuneResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobAutotuneFactoryExtensions
{
}
