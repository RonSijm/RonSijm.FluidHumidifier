// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerGroupDefinitionPortConfigurationFactory(Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration>
{

    protected override Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration Create()
    {
        var portConfigurationResult = CreatePortConfiguration();
        factoryAction?.Invoke(portConfigurationResult);

        return portConfigurationResult;
    }

    private Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration CreatePortConfiguration()
    {
        var portConfigurationResult = new Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration();

        return portConfigurationResult;
    }

} // End Of Class

public static class InnerContainerGroupDefinitionPortConfigurationFactoryExtensions
{
}
