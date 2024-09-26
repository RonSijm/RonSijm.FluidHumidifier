// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerFunctionConfigurationLambdaConflictHandlerConfigFactory(Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig>
{

    protected override Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig Create()
    {
        var lambdaConflictHandlerConfigResult = CreateLambdaConflictHandlerConfig();
        factoryAction?.Invoke(lambdaConflictHandlerConfigResult);

        return lambdaConflictHandlerConfigResult;
    }

    private Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig CreateLambdaConflictHandlerConfig()
    {
        var lambdaConflictHandlerConfigResult = new Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig();

        return lambdaConflictHandlerConfigResult;
    }

} // End Of Class

public static class InnerFunctionConfigurationLambdaConflictHandlerConfigFactoryExtensions
{
}
