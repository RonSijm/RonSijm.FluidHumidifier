// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionFunctionFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.Function>
{

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.Function Create()
    {
        var functionResult = CreateFunction();
        factoryAction?.Invoke(functionResult);

        return functionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.Function CreateFunction()
    {
        var functionResult = new Humidifier.Greengrass.FunctionDefinitionTypes.Function();

        return functionResult;
    }

} // End Of Class

public static class InnerFunctionDefinitionFunctionFactoryExtensions
{
}
