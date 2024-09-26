// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerNodeNodeConfigurationFactory(Action<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration>
{

    protected override Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration Create()
    {
        var nodeConfigurationResult = CreateNodeConfiguration();
        factoryAction?.Invoke(nodeConfigurationResult);

        return nodeConfigurationResult;
    }

    private Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration CreateNodeConfiguration()
    {
        var nodeConfigurationResult = new Humidifier.ManagedBlockchain.NodeTypes.NodeConfiguration();

        return nodeConfigurationResult;
    }

} // End Of Class

public static class InnerNodeNodeConfigurationFactoryExtensions
{
}
