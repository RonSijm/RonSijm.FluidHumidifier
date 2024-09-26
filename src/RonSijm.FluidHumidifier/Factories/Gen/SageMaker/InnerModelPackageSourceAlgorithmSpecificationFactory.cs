// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageSourceAlgorithmSpecificationFactory(Action<Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithmSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithmSpecification>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithmSpecification Create()
    {
        var sourceAlgorithmSpecificationResult = CreateSourceAlgorithmSpecification();
        factoryAction?.Invoke(sourceAlgorithmSpecificationResult);

        return sourceAlgorithmSpecificationResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithmSpecification CreateSourceAlgorithmSpecification()
    {
        var sourceAlgorithmSpecificationResult = new Humidifier.SageMaker.ModelPackageTypes.SourceAlgorithmSpecification();

        return sourceAlgorithmSpecificationResult;
    }

} // End Of Class

public static class InnerModelPackageSourceAlgorithmSpecificationFactoryExtensions
{
}
