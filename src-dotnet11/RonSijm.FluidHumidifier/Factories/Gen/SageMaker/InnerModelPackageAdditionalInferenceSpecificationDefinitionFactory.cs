// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageAdditionalInferenceSpecificationDefinitionFactory(Action<Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition Create()
    {
        var additionalInferenceSpecificationDefinitionResult = CreateAdditionalInferenceSpecificationDefinition();
        factoryAction?.Invoke(additionalInferenceSpecificationDefinitionResult);

        return additionalInferenceSpecificationDefinitionResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition CreateAdditionalInferenceSpecificationDefinition()
    {
        var additionalInferenceSpecificationDefinitionResult = new Humidifier.SageMaker.ModelPackageTypes.AdditionalInferenceSpecificationDefinition();

        return additionalInferenceSpecificationDefinitionResult;
    }

} // End Of Class

public static class InnerModelPackageAdditionalInferenceSpecificationDefinitionFactoryExtensions
{
}
