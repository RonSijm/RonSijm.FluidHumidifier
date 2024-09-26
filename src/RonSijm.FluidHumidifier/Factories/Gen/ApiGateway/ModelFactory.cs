// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class ModelFactory(string resourceName = null, Action<Humidifier.ApiGateway.Model> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Model>(resourceName)
{

    protected override Humidifier.ApiGateway.Model Create()
    {
        var modelResult = CreateModel();
        factoryAction?.Invoke(modelResult);

        return modelResult;
    }

    private Humidifier.ApiGateway.Model CreateModel()
    {
        var modelResult = new Humidifier.ApiGateway.Model
        {
            GivenName = InputResourceName,
        };

        return modelResult;
    }

} // End Of Class

public static class ModelFactoryExtensions
{
}
