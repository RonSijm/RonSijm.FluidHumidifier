// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmContainerConfigFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.ContainerConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.ContainerConfig>
{

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.ContainerConfig Create()
    {
        var containerConfigResult = CreateContainerConfig();
        factoryAction?.Invoke(containerConfigResult);

        return containerConfigResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.ContainerConfig CreateContainerConfig()
    {
        var containerConfigResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.ContainerConfig();

        return containerConfigResult;
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmContainerConfigFactoryExtensions
{
}
