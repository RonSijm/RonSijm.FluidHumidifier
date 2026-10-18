// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerResolverPipelineConfigFactory(Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ResolverTypes.PipelineConfig>
{

    protected override Humidifier.AppSync.ResolverTypes.PipelineConfig Create()
    {
        var pipelineConfigResult = CreatePipelineConfig();
        factoryAction?.Invoke(pipelineConfigResult);

        return pipelineConfigResult;
    }

    private Humidifier.AppSync.ResolverTypes.PipelineConfig CreatePipelineConfig()
    {
        var pipelineConfigResult = new Humidifier.AppSync.ResolverTypes.PipelineConfig();

        return pipelineConfigResult;
    }

} // End Of Class

public static class InnerResolverPipelineConfigFactoryExtensions
{
}
