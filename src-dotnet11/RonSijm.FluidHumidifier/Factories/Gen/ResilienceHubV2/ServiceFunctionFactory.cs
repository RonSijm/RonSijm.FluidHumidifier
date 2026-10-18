// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class ServiceFunctionFactory(string resourceName = null, Action<Humidifier.ResilienceHubV2.ServiceFunction> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHubV2.ServiceFunction>(resourceName)
{

    protected override Humidifier.ResilienceHubV2.ServiceFunction Create()
    {
        var serviceFunctionResult = CreateServiceFunction();
        factoryAction?.Invoke(serviceFunctionResult);

        return serviceFunctionResult;
    }

    private Humidifier.ResilienceHubV2.ServiceFunction CreateServiceFunction()
    {
        var serviceFunctionResult = new Humidifier.ResilienceHubV2.ServiceFunction
        {
            GivenName = InputResourceName,
        };

        return serviceFunctionResult;
    }

} // End Of Class

public static class ServiceFunctionFactoryExtensions
{
}
