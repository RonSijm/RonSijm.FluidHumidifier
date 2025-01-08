// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineRetryConfigurationFactory(Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration>
{

    protected override Humidifier.CodePipeline.PipelineTypes.RetryConfiguration Create()
    {
        var retryConfigurationResult = CreateRetryConfiguration();
        factoryAction?.Invoke(retryConfigurationResult);

        return retryConfigurationResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.RetryConfiguration CreateRetryConfiguration()
    {
        var retryConfigurationResult = new Humidifier.CodePipeline.PipelineTypes.RetryConfiguration();

        return retryConfigurationResult;
    }

} // End Of Class

public static class InnerPipelineRetryConfigurationFactoryExtensions
{
}
