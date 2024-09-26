// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerGroupDefinitionContainerHealthCheckFactory(Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck>
{

    protected override Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck Create()
    {
        var containerHealthCheckResult = CreateContainerHealthCheck();
        factoryAction?.Invoke(containerHealthCheckResult);

        return containerHealthCheckResult;
    }

    private Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck CreateContainerHealthCheck()
    {
        var containerHealthCheckResult = new Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck();

        return containerHealthCheckResult;
    }

} // End Of Class

public static class InnerContainerGroupDefinitionContainerHealthCheckFactoryExtensions
{
}
