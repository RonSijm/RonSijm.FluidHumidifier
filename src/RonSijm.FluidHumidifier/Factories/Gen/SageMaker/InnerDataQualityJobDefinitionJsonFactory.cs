// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionJsonFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json Create()
    {
        var jsonResult = CreateJson();
        factoryAction?.Invoke(jsonResult);

        return jsonResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json CreateJson()
    {
        var jsonResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json();

        return jsonResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionJsonFactoryExtensions
{
}
