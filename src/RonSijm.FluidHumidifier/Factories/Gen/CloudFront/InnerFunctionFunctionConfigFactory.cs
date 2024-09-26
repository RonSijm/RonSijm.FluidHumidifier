// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerFunctionFunctionConfigFactory(Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.FunctionTypes.FunctionConfig>
{

    protected override Humidifier.CloudFront.FunctionTypes.FunctionConfig Create()
    {
        var functionConfigResult = CreateFunctionConfig();
        factoryAction?.Invoke(functionConfigResult);

        return functionConfigResult;
    }

    private Humidifier.CloudFront.FunctionTypes.FunctionConfig CreateFunctionConfig()
    {
        var functionConfigResult = new Humidifier.CloudFront.FunctionTypes.FunctionConfig();

        return functionConfigResult;
    }

} // End Of Class

public static class InnerFunctionFunctionConfigFactoryExtensions
{
}
