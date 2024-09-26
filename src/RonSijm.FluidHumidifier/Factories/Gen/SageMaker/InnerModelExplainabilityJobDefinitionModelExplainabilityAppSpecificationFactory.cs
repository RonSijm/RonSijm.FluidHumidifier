// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionModelExplainabilityAppSpecificationFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityAppSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityAppSpecification>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityAppSpecification Create()
    {
        var modelExplainabilityAppSpecificationResult = CreateModelExplainabilityAppSpecification();
        factoryAction?.Invoke(modelExplainabilityAppSpecificationResult);

        return modelExplainabilityAppSpecificationResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityAppSpecification CreateModelExplainabilityAppSpecification()
    {
        var modelExplainabilityAppSpecificationResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityAppSpecification();

        return modelExplainabilityAppSpecificationResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionModelExplainabilityAppSpecificationFactoryExtensions
{
}
