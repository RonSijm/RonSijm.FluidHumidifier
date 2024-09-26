// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelinePipelineTriggerDeclarationFactory(Action<Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration>
{

    internal InnerPipelineGitConfigurationFactory GitConfigurationFactory { get; set; }

    protected override Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration Create()
    {
        var pipelineTriggerDeclarationResult = CreatePipelineTriggerDeclaration();
        factoryAction?.Invoke(pipelineTriggerDeclarationResult);

        return pipelineTriggerDeclarationResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration CreatePipelineTriggerDeclaration()
    {
        var pipelineTriggerDeclarationResult = new Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration();

        return pipelineTriggerDeclarationResult;
    }
    public override void CreateChildren(Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration result)
    {
        base.CreateChildren(result);

        result.GitConfiguration ??= GitConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPipelinePipelineTriggerDeclarationFactoryExtensions
{
    public static CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, InnerPipelineGitConfigurationFactory> WithGitConfiguration(this InnerPipelinePipelineTriggerDeclarationFactory parentFactory, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null)
    {
        parentFactory.GitConfigurationFactory = new InnerPipelineGitConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GitConfigurationFactory);
    }

    public static CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1>(this CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1>(this CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, T2, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2>(this CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, T2, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2>(this CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelinePipelineTriggerDeclarationFactory, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPipelinePipelineTriggerDeclarationFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, T2, T3, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3>(this CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, T2, T3, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelinePipelineTriggerDeclarationFactory, T3, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelinePipelineTriggerDeclarationFactory, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelinePipelineTriggerDeclarationFactory, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelinePipelineTriggerDeclarationFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, T2, T3, T4, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPipelinePipelineTriggerDeclarationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, T2, T3, T4, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelinePipelineTriggerDeclarationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelinePipelineTriggerDeclarationFactory, T3, T4, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelinePipelineTriggerDeclarationFactory, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelinePipelineTriggerDeclarationFactory, T4, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelinePipelineTriggerDeclarationFactory, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelinePipelineTriggerDeclarationFactory, InnerPipelineGitConfigurationFactory> WithGitConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelinePipelineTriggerDeclarationFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.GitConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfiguration(combinedResult.T5, subFactoryAction));
}
