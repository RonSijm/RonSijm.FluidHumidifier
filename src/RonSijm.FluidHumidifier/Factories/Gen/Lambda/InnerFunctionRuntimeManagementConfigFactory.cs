// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionRuntimeManagementConfigFactory(Action<Humidifier.Lambda.FunctionTypes.RuntimeManagementConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.RuntimeManagementConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.RuntimeManagementConfig Create()
    {
        var runtimeManagementConfigResult = CreateRuntimeManagementConfig();
        factoryAction?.Invoke(runtimeManagementConfigResult);

        return runtimeManagementConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.RuntimeManagementConfig CreateRuntimeManagementConfig()
    {
        var runtimeManagementConfigResult = new Humidifier.Lambda.FunctionTypes.RuntimeManagementConfig();

        return runtimeManagementConfigResult;
    }

} // End Of Class

public static class InnerFunctionRuntimeManagementConfigFactoryExtensions
{
}
