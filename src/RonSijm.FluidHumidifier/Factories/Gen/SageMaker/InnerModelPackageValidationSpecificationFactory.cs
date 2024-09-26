// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageValidationSpecificationFactory(Action<Humidifier.SageMaker.ModelPackageTypes.ValidationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.ValidationSpecification>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.ValidationSpecification Create()
    {
        var validationSpecificationResult = CreateValidationSpecification();
        factoryAction?.Invoke(validationSpecificationResult);

        return validationSpecificationResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.ValidationSpecification CreateValidationSpecification()
    {
        var validationSpecificationResult = new Humidifier.SageMaker.ModelPackageTypes.ValidationSpecification();

        return validationSpecificationResult;
    }

} // End Of Class

public static class InnerModelPackageValidationSpecificationFactoryExtensions
{
}
