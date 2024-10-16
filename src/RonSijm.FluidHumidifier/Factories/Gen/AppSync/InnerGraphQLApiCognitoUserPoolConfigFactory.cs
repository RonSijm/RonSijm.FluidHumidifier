// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerGraphQLApiCognitoUserPoolConfigFactory(Action<Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig>
{

    protected override Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig Create()
    {
        var cognitoUserPoolConfigResult = CreateCognitoUserPoolConfig();
        factoryAction?.Invoke(cognitoUserPoolConfigResult);

        return cognitoUserPoolConfigResult;
    }

    private Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig CreateCognitoUserPoolConfig()
    {
        var cognitoUserPoolConfigResult = new Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig();

        return cognitoUserPoolConfigResult;
    }

} // End Of Class

public static class InnerGraphQLApiCognitoUserPoolConfigFactoryExtensions
{
}
