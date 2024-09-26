// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class ModelFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Model> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Model>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.Model Create()
    {
        var modelResult = CreateModel();
        factoryAction?.Invoke(modelResult);

        return modelResult;
    }

    private Humidifier.ApiGatewayV2.Model CreateModel()
    {
        var modelResult = new Humidifier.ApiGatewayV2.Model
        {
            GivenName = InputResourceName,
        };

        return modelResult;
    }

} // End Of Class

public static class ModelFactoryExtensions
{
}
