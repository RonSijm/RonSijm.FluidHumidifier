// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration>
{

    internal InnerMediaCapturePipelineGridViewConfigurationFactory GridViewConfigurationFactory { get; set; }

    protected override Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration Create()
    {
        var compositedVideoArtifactsConfigurationResult = CreateCompositedVideoArtifactsConfiguration();
        factoryAction?.Invoke(compositedVideoArtifactsConfigurationResult);

        return compositedVideoArtifactsConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration CreateCompositedVideoArtifactsConfiguration()
    {
        var compositedVideoArtifactsConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration();

        return compositedVideoArtifactsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration result)
    {
        base.CreateChildren(result);

        result.GridViewConfiguration ??= GridViewConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration(this InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null)
    {
        parentFactory.GridViewConfigurationFactory = new InnerMediaCapturePipelineGridViewConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GridViewConfigurationFactory);
    }

    public static CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1>(this CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1>(this CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2>(this CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T2, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2>(this CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T2, T3, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T3, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3, T4, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T2, T3, T4, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T3, T4, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T4, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaCapturePipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaCapturePipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T5, subFactoryAction).T2);
}
