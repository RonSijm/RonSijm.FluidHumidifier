// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionJsonFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json Create()
    {
        var jsonResult = CreateJson();
        factoryAction?.Invoke(jsonResult);

        return jsonResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json CreateJson()
    {
        var jsonResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json();

        return jsonResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionJsonFactoryExtensions
{
}
