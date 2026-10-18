// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationMCPServerSplunkConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.MCPServerSplunkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.MCPServerSplunkConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.MCPServerSplunkConfiguration Create()
    {
        var mCPServerSplunkConfigurationResult = CreateMCPServerSplunkConfiguration();
        factoryAction?.Invoke(mCPServerSplunkConfigurationResult);

        return mCPServerSplunkConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.MCPServerSplunkConfiguration CreateMCPServerSplunkConfiguration()
    {
        var mCPServerSplunkConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.MCPServerSplunkConfiguration();

        return mCPServerSplunkConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationMCPServerSplunkConfigurationFactoryExtensions
{
}
