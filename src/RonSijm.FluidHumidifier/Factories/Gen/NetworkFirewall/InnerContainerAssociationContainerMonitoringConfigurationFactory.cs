// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerContainerAssociationContainerMonitoringConfigurationFactory(Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration>
{

    protected override Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration Create()
    {
        var containerMonitoringConfigurationResult = CreateContainerMonitoringConfiguration();
        factoryAction?.Invoke(containerMonitoringConfigurationResult);

        return containerMonitoringConfigurationResult;
    }

    private Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration CreateContainerMonitoringConfiguration()
    {
        var containerMonitoringConfigurationResult = new Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration();

        return containerMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerContainerAssociationContainerMonitoringConfigurationFactoryExtensions
{
}
