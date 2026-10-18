// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionFunctionScalingConfigFactory(Action<Humidifier.Lambda.FunctionTypes.FunctionScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.FunctionScalingConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.FunctionScalingConfig Create()
    {
        var functionScalingConfigResult = CreateFunctionScalingConfig();
        factoryAction?.Invoke(functionScalingConfigResult);

        return functionScalingConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.FunctionScalingConfig CreateFunctionScalingConfig()
    {
        var functionScalingConfigResult = new Humidifier.Lambda.FunctionTypes.FunctionScalingConfig();

        return functionScalingConfigResult;
    }

} // End Of Class

public static class InnerFunctionFunctionScalingConfigFactoryExtensions
{
}
