// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineGitConfigurationFactory(Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.GitConfiguration>
{

    protected override Humidifier.CodePipeline.PipelineTypes.GitConfiguration Create()
    {
        var gitConfigurationResult = CreateGitConfiguration();
        factoryAction?.Invoke(gitConfigurationResult);

        return gitConfigurationResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.GitConfiguration CreateGitConfiguration()
    {
        var gitConfigurationResult = new Humidifier.CodePipeline.PipelineTypes.GitConfiguration();

        return gitConfigurationResult;
    }

} // End Of Class

public static class InnerPipelineGitConfigurationFactoryExtensions
{
}
