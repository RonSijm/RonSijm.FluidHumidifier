// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionModelQualityAppSpecificationFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityAppSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityAppSpecification>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityAppSpecification Create()
    {
        var modelQualityAppSpecificationResult = CreateModelQualityAppSpecification();
        factoryAction?.Invoke(modelQualityAppSpecificationResult);

        return modelQualityAppSpecificationResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityAppSpecification CreateModelQualityAppSpecification()
    {
        var modelQualityAppSpecificationResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityAppSpecification();

        return modelQualityAppSpecificationResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionModelQualityAppSpecificationFactoryExtensions
{
}
