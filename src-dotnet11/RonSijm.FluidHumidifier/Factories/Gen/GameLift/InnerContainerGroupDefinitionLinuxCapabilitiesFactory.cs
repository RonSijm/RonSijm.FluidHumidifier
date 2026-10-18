// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerGroupDefinitionLinuxCapabilitiesFactory(Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities>
{

    protected override Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities Create()
    {
        var linuxCapabilitiesResult = CreateLinuxCapabilities();
        factoryAction?.Invoke(linuxCapabilitiesResult);

        return linuxCapabilitiesResult;
    }

    private Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities CreateLinuxCapabilities()
    {
        var linuxCapabilitiesResult = new Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities();

        return linuxCapabilitiesResult;
    }

} // End Of Class

public static class InnerContainerGroupDefinitionLinuxCapabilitiesFactoryExtensions
{
}
