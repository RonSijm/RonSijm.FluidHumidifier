// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionJsonFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Json> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Json>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Json Create()
    {
        var jsonResult = CreateJson();
        factoryAction?.Invoke(jsonResult);

        return jsonResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Json CreateJson()
    {
        var jsonResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Json();

        return jsonResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionJsonFactoryExtensions
{
}
