// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerGraphQLApiLambdaAuthorizerConfigFactory(Action<Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig>
{

    protected override Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig Create()
    {
        var lambdaAuthorizerConfigResult = CreateLambdaAuthorizerConfig();
        factoryAction?.Invoke(lambdaAuthorizerConfigResult);

        return lambdaAuthorizerConfigResult;
    }

    private Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig CreateLambdaAuthorizerConfig()
    {
        var lambdaAuthorizerConfigResult = new Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig();

        return lambdaAuthorizerConfigResult;
    }

} // End Of Class

public static class InnerGraphQLApiLambdaAuthorizerConfigFactoryExtensions
{
}
