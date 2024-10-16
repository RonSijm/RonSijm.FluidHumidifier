// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionRuntimePlatformFactory(Action<Humidifier.Batch.JobDefinitionTypes.RuntimePlatform> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.RuntimePlatform>
{

    protected override Humidifier.Batch.JobDefinitionTypes.RuntimePlatform Create()
    {
        var runtimePlatformResult = CreateRuntimePlatform();
        factoryAction?.Invoke(runtimePlatformResult);

        return runtimePlatformResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.RuntimePlatform CreateRuntimePlatform()
    {
        var runtimePlatformResult = new Humidifier.Batch.JobDefinitionTypes.RuntimePlatform();

        return runtimePlatformResult;
    }

} // End Of Class

public static class InnerJobDefinitionRuntimePlatformFactoryExtensions
{
}
