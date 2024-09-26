// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerResolverLambdaConflictHandlerConfigFactory(Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig>
{

    protected override Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig Create()
    {
        var lambdaConflictHandlerConfigResult = CreateLambdaConflictHandlerConfig();
        factoryAction?.Invoke(lambdaConflictHandlerConfigResult);

        return lambdaConflictHandlerConfigResult;
    }

    private Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig CreateLambdaConflictHandlerConfig()
    {
        var lambdaConflictHandlerConfigResult = new Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig();

        return lambdaConflictHandlerConfigResult;
    }

} // End Of Class

public static class InnerResolverLambdaConflictHandlerConfigFactoryExtensions
{
}
