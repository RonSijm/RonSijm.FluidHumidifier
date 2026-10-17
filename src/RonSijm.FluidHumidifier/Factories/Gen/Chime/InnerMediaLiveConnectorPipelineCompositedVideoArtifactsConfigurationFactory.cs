// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration>
{

    internal InnerMediaLiveConnectorPipelineGridViewConfigurationFactory GridViewConfigurationFactory { get; set; }

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration Create()
    {
        var compositedVideoArtifactsConfigurationResult = CreateCompositedVideoArtifactsConfiguration();
        factoryAction?.Invoke(compositedVideoArtifactsConfigurationResult);

        return compositedVideoArtifactsConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration CreateCompositedVideoArtifactsConfiguration()
    {
        var compositedVideoArtifactsConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration();

        return compositedVideoArtifactsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration result)
    {
        base.CreateChildren(result);

        result.GridViewConfiguration ??= GridViewConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration(this InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null)
    {
        parentFactory.GridViewConfigurationFactory = new InnerMediaLiveConnectorPipelineGridViewConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GridViewConfigurationFactory);
    }

    public static CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1>(this CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2>(this CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T2, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T2, T3, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T3, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3, T4, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T2, T3, T4, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T3, T4, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T4, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory, InnerMediaLiveConnectorPipelineGridViewConfigurationFactory> WithGridViewConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaLiveConnectorPipelineCompositedVideoArtifactsConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGridViewConfiguration(combinedResult.T5, subFactoryAction).T2);
}
