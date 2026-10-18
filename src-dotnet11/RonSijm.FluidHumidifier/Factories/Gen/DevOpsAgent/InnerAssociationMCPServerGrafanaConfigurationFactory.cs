// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationMCPServerGrafanaConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.MCPServerGrafanaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.MCPServerGrafanaConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.MCPServerGrafanaConfiguration Create()
    {
        var mCPServerGrafanaConfigurationResult = CreateMCPServerGrafanaConfiguration();
        factoryAction?.Invoke(mCPServerGrafanaConfigurationResult);

        return mCPServerGrafanaConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.MCPServerGrafanaConfiguration CreateMCPServerGrafanaConfiguration()
    {
        var mCPServerGrafanaConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.MCPServerGrafanaConfiguration();

        return mCPServerGrafanaConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationMCPServerGrafanaConfigurationFactoryExtensions
{
}
