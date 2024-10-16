// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerGroupDefinitionMemoryLimitsFactory(Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.MemoryLimits> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerGroupDefinitionTypes.MemoryLimits>
{

    protected override Humidifier.GameLift.ContainerGroupDefinitionTypes.MemoryLimits Create()
    {
        var memoryLimitsResult = CreateMemoryLimits();
        factoryAction?.Invoke(memoryLimitsResult);

        return memoryLimitsResult;
    }

    private Humidifier.GameLift.ContainerGroupDefinitionTypes.MemoryLimits CreateMemoryLimits()
    {
        var memoryLimitsResult = new Humidifier.GameLift.ContainerGroupDefinitionTypes.MemoryLimits();

        return memoryLimitsResult;
    }

} // End Of Class

public static class InnerContainerGroupDefinitionMemoryLimitsFactoryExtensions
{
}
