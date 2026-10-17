// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAAServerless;

public class InnerWorkflowNetworkConfigurationFactory(Action<Humidifier.MWAAServerless.WorkflowTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MWAAServerless.WorkflowTypes.NetworkConfiguration>
{

    protected override Humidifier.MWAAServerless.WorkflowTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.MWAAServerless.WorkflowTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.MWAAServerless.WorkflowTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }

} // End Of Class

public static class InnerWorkflowNetworkConfigurationFactoryExtensions
{
}
