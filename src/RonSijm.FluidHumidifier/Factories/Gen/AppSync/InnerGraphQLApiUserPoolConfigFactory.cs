// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerGraphQLApiUserPoolConfigFactory(Action<Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig>
{

    protected override Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig Create()
    {
        var userPoolConfigResult = CreateUserPoolConfig();
        factoryAction?.Invoke(userPoolConfigResult);

        return userPoolConfigResult;
    }

    private Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig CreateUserPoolConfig()
    {
        var userPoolConfigResult = new Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig();

        return userPoolConfigResult;
    }

} // End Of Class

public static class InnerGraphQLApiUserPoolConfigFactoryExtensions
{
}
