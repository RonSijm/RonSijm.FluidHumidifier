// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory(Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig Create()
    {
        var lambdaManagedInstancesCapacityProviderConfigResult = CreateLambdaManagedInstancesCapacityProviderConfig();
        factoryAction?.Invoke(lambdaManagedInstancesCapacityProviderConfigResult);

        return lambdaManagedInstancesCapacityProviderConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig CreateLambdaManagedInstancesCapacityProviderConfig()
    {
        var lambdaManagedInstancesCapacityProviderConfigResult = new Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig();

        return lambdaManagedInstancesCapacityProviderConfigResult;
    }

} // End Of Class

public static class InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactoryExtensions
{
}
