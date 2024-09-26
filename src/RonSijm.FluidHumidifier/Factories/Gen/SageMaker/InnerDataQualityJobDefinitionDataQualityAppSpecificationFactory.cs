// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionDataQualityAppSpecificationFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityAppSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityAppSpecification>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityAppSpecification Create()
    {
        var dataQualityAppSpecificationResult = CreateDataQualityAppSpecification();
        factoryAction?.Invoke(dataQualityAppSpecificationResult);

        return dataQualityAppSpecificationResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityAppSpecification CreateDataQualityAppSpecification()
    {
        var dataQualityAppSpecificationResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityAppSpecification();

        return dataQualityAppSpecificationResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionDataQualityAppSpecificationFactoryExtensions
{
}
