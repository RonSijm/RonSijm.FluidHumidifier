// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceLambdaConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.LambdaConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.LambdaConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.LambdaConfig Create()
    {
        var lambdaConfigResult = CreateLambdaConfig();
        factoryAction?.Invoke(lambdaConfigResult);

        return lambdaConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.LambdaConfig CreateLambdaConfig()
    {
        var lambdaConfigResult = new Humidifier.AppSync.DataSourceTypes.LambdaConfig();

        return lambdaConfigResult;
    }

} // End Of Class

public static class InnerDataSourceLambdaConfigFactoryExtensions
{
}
