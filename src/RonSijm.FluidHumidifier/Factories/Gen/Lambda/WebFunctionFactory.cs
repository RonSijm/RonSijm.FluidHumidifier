// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class WebFunctionFactory(string resourceName = null, Action<Humidifier.Lambda.WebFunction> factoryAction = null) : ResourceFactory<Humidifier.Lambda.WebFunction>(resourceName)
{

    protected override Humidifier.Lambda.WebFunction Create()
    {
        var webFunctionResult = CreateWebFunction();
        factoryAction?.Invoke(webFunctionResult);

        return webFunctionResult;
    }

    private Humidifier.Lambda.WebFunction CreateWebFunction()
    {
        var webFunctionResult = new Humidifier.Lambda.WebFunction
        {
            GivenName = InputResourceName,
        };

        return webFunctionResult;
    }

} // End Of Class

public static class WebFunctionFactoryExtensions
{
}
