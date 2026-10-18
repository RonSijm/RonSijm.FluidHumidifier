// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobConvergenceDetectedFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.ConvergenceDetected> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.ConvergenceDetected>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.ConvergenceDetected Create()
    {
        var convergenceDetectedResult = CreateConvergenceDetected();
        factoryAction?.Invoke(convergenceDetectedResult);

        return convergenceDetectedResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.ConvergenceDetected CreateConvergenceDetected()
    {
        var convergenceDetectedResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.ConvergenceDetected();

        return convergenceDetectedResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobConvergenceDetectedFactoryExtensions
{
}
