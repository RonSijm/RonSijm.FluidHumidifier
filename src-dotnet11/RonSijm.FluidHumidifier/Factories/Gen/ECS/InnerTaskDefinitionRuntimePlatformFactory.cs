// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionRuntimePlatformFactory(Action<Humidifier.ECS.TaskDefinitionTypes.RuntimePlatform> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.RuntimePlatform>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.RuntimePlatform Create()
    {
        var runtimePlatformResult = CreateRuntimePlatform();
        factoryAction?.Invoke(runtimePlatformResult);

        return runtimePlatformResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.RuntimePlatform CreateRuntimePlatform()
    {
        var runtimePlatformResult = new Humidifier.ECS.TaskDefinitionTypes.RuntimePlatform();

        return runtimePlatformResult;
    }

} // End Of Class

public static class InnerTaskDefinitionRuntimePlatformFactoryExtensions
{
}
