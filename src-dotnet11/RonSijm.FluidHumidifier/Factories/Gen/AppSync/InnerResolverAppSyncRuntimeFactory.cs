// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerResolverAppSyncRuntimeFactory(Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ResolverTypes.AppSyncRuntime>
{

    protected override Humidifier.AppSync.ResolverTypes.AppSyncRuntime Create()
    {
        var appSyncRuntimeResult = CreateAppSyncRuntime();
        factoryAction?.Invoke(appSyncRuntimeResult);

        return appSyncRuntimeResult;
    }

    private Humidifier.AppSync.ResolverTypes.AppSyncRuntime CreateAppSyncRuntime()
    {
        var appSyncRuntimeResult = new Humidifier.AppSync.ResolverTypes.AppSyncRuntime();

        return appSyncRuntimeResult;
    }

} // End Of Class

public static class InnerResolverAppSyncRuntimeFactoryExtensions
{
}
