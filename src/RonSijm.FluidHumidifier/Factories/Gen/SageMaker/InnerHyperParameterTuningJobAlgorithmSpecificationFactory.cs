// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobAlgorithmSpecificationFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.AlgorithmSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.AlgorithmSpecification>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.AlgorithmSpecification Create()
    {
        var algorithmSpecificationResult = CreateAlgorithmSpecification();
        factoryAction?.Invoke(algorithmSpecificationResult);

        return algorithmSpecificationResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.AlgorithmSpecification CreateAlgorithmSpecification()
    {
        var algorithmSpecificationResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.AlgorithmSpecification();

        return algorithmSpecificationResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobAlgorithmSpecificationFactoryExtensions
{
}
