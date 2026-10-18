// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationMCPServerDatadogConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.MCPServerDatadogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.MCPServerDatadogConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.MCPServerDatadogConfiguration Create()
    {
        var mCPServerDatadogConfigurationResult = CreateMCPServerDatadogConfiguration();
        factoryAction?.Invoke(mCPServerDatadogConfigurationResult);

        return mCPServerDatadogConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.MCPServerDatadogConfiguration CreateMCPServerDatadogConfiguration()
    {
        var mCPServerDatadogConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.MCPServerDatadogConfiguration();

        return mCPServerDatadogConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationMCPServerDatadogConfigurationFactoryExtensions
{
}
