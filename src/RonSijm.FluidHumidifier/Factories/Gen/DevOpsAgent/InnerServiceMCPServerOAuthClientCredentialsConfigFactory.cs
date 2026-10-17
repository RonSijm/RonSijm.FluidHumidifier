// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerOAuthClientCredentialsConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig Create()
    {
        var mCPServerOAuthClientCredentialsConfigResult = CreateMCPServerOAuthClientCredentialsConfig();
        factoryAction?.Invoke(mCPServerOAuthClientCredentialsConfigResult);

        return mCPServerOAuthClientCredentialsConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig CreateMCPServerOAuthClientCredentialsConfig()
    {
        var mCPServerOAuthClientCredentialsConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig();

        return mCPServerOAuthClientCredentialsConfigResult;
    }

} // End Of Class

public static class InnerServiceMCPServerOAuthClientCredentialsConfigFactoryExtensions
{
}
