// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerGraphQLApiOpenIDConnectConfigFactory(Action<Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig>
{

    protected override Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig Create()
    {
        var openIDConnectConfigResult = CreateOpenIDConnectConfig();
        factoryAction?.Invoke(openIDConnectConfigResult);

        return openIDConnectConfigResult;
    }

    private Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig CreateOpenIDConnectConfig()
    {
        var openIDConnectConfigResult = new Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig();

        return openIDConnectConfigResult;
    }

} // End Of Class

public static class InnerGraphQLApiOpenIDConnectConfigFactoryExtensions
{
}
