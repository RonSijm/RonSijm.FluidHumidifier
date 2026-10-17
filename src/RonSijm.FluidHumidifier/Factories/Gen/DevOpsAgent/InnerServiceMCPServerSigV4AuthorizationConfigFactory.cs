// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerSigV4AuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig Create()
    {
        var mCPServerSigV4AuthorizationConfigResult = CreateMCPServerSigV4AuthorizationConfig();
        factoryAction?.Invoke(mCPServerSigV4AuthorizationConfigResult);

        return mCPServerSigV4AuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig CreateMCPServerSigV4AuthorizationConfig()
    {
        var mCPServerSigV4AuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig();

        return mCPServerSigV4AuthorizationConfigResult;
    }

} // End Of Class

public static class InnerServiceMCPServerSigV4AuthorizationConfigFactoryExtensions
{
}
