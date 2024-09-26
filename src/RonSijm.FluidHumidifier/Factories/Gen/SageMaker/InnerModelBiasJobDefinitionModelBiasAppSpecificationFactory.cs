// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionModelBiasAppSpecificationFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasAppSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasAppSpecification>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasAppSpecification Create()
    {
        var modelBiasAppSpecificationResult = CreateModelBiasAppSpecification();
        factoryAction?.Invoke(modelBiasAppSpecificationResult);

        return modelBiasAppSpecificationResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasAppSpecification CreateModelBiasAppSpecification()
    {
        var modelBiasAppSpecificationResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ModelBiasAppSpecification();

        return modelBiasAppSpecificationResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionModelBiasAppSpecificationFactoryExtensions
{
}
