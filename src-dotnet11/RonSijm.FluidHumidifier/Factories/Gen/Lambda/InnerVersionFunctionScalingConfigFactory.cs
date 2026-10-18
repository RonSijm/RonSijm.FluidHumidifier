// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerVersionFunctionScalingConfigFactory(Action<Humidifier.Lambda.VersionTypes.FunctionScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.VersionTypes.FunctionScalingConfig>
{

    protected override Humidifier.Lambda.VersionTypes.FunctionScalingConfig Create()
    {
        var functionScalingConfigResult = CreateFunctionScalingConfig();
        factoryAction?.Invoke(functionScalingConfigResult);

        return functionScalingConfigResult;
    }

    private Humidifier.Lambda.VersionTypes.FunctionScalingConfig CreateFunctionScalingConfig()
    {
        var functionScalingConfigResult = new Humidifier.Lambda.VersionTypes.FunctionScalingConfig();

        return functionScalingConfigResult;
    }

} // End Of Class

public static class InnerVersionFunctionScalingConfigFactoryExtensions
{
}
