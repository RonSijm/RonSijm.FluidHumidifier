// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationMCPServerNewRelicConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.MCPServerNewRelicConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.MCPServerNewRelicConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.MCPServerNewRelicConfiguration Create()
    {
        var mCPServerNewRelicConfigurationResult = CreateMCPServerNewRelicConfiguration();
        factoryAction?.Invoke(mCPServerNewRelicConfigurationResult);

        return mCPServerNewRelicConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.MCPServerNewRelicConfiguration CreateMCPServerNewRelicConfiguration()
    {
        var mCPServerNewRelicConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.MCPServerNewRelicConfiguration();

        return mCPServerNewRelicConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationMCPServerNewRelicConfigurationFactoryExtensions
{
}
