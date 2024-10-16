// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAppImageConfigContainerConfigFactory(Action<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig>
{

    protected override Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig Create()
    {
        var containerConfigResult = CreateContainerConfig();
        factoryAction?.Invoke(containerConfigResult);

        return containerConfigResult;
    }

    private Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig CreateContainerConfig()
    {
        var containerConfigResult = new Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig();

        return containerConfigResult;
    }

} // End Of Class

public static class InnerAppImageConfigContainerConfigFactoryExtensions
{
}
