// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAlgorithmTrainingSpecificationFactory(Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification>
{

    protected override Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification Create()
    {
        var trainingSpecificationResult = CreateTrainingSpecification();
        factoryAction?.Invoke(trainingSpecificationResult);

        return trainingSpecificationResult;
    }

    private Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification CreateTrainingSpecification()
    {
        var trainingSpecificationResult = new Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification();

        return trainingSpecificationResult;
    }

} // End Of Class

public static class InnerAlgorithmTrainingSpecificationFactoryExtensions
{
}
