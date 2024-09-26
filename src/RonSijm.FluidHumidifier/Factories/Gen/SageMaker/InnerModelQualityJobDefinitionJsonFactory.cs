// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionJsonFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json Create()
    {
        var jsonResult = CreateJson();
        factoryAction?.Invoke(jsonResult);

        return jsonResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json CreateJson()
    {
        var jsonResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json();

        return jsonResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionJsonFactoryExtensions
{
}
