// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineSourceConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration>
{

    internal InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory SelectedVideoStreamsFactory { get; set; }

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration Create()
    {
        var sourceConfigurationResult = CreateSourceConfiguration();
        factoryAction?.Invoke(sourceConfigurationResult);

        return sourceConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration CreateSourceConfiguration()
    {
        var sourceConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration();

        return sourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration result)
    {
        base.CreateChildren(result);

        result.SelectedVideoStreams ??= SelectedVideoStreamsFactory?.Build();
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams(this InnerMediaLiveConnectorPipelineSourceConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null)
    {
        parentFactory.SelectedVideoStreamsFactory = new InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelectedVideoStreamsFactory);
    }

    public static CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1>(this CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, T2, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2>(this CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T2, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, T2, T3, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T2, T3, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T3, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, T2, T3, T4, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T2, T3, T4, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T3, T4, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T4, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaLiveConnectorPipelineSourceConfigurationFactory, InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaLiveConnectorPipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T5, subFactoryAction).T2);
}
