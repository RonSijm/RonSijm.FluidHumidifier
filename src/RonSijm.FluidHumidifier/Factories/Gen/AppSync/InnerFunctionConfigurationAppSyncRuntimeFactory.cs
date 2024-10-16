// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerFunctionConfigurationAppSyncRuntimeFactory(Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime>
{

    protected override Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime Create()
    {
        var appSyncRuntimeResult = CreateAppSyncRuntime();
        factoryAction?.Invoke(appSyncRuntimeResult);

        return appSyncRuntimeResult;
    }

    private Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime CreateAppSyncRuntime()
    {
        var appSyncRuntimeResult = new Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime();

        return appSyncRuntimeResult;
    }

} // End Of Class

public static class InnerFunctionConfigurationAppSyncRuntimeFactoryExtensions
{
}
