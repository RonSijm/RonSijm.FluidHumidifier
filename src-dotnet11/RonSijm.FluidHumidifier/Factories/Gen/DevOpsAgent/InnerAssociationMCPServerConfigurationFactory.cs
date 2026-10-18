// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationMCPServerConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.MCPServerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.MCPServerConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.MCPServerConfiguration Create()
    {
        var mCPServerConfigurationResult = CreateMCPServerConfiguration();
        factoryAction?.Invoke(mCPServerConfigurationResult);

        return mCPServerConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.MCPServerConfiguration CreateMCPServerConfiguration()
    {
        var mCPServerConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.MCPServerConfiguration();

        return mCPServerConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationMCPServerConfigurationFactoryExtensions
{
}
