// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobParameterRangesFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges Create()
    {
        var parameterRangesResult = CreateParameterRanges();
        factoryAction?.Invoke(parameterRangesResult);

        return parameterRangesResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges CreateParameterRanges()
    {
        var parameterRangesResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges();

        return parameterRangesResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobParameterRangesFactoryExtensions
{
}
