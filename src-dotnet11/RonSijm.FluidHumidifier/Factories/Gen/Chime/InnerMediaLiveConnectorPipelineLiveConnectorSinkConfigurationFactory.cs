// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration>
{

    internal InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory RTMPConfigurationFactory { get; set; }

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration Create()
    {
        var liveConnectorSinkConfigurationResult = CreateLiveConnectorSinkConfiguration();
        factoryAction?.Invoke(liveConnectorSinkConfigurationResult);

        return liveConnectorSinkConfigurationResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration CreateLiveConnectorSinkConfiguration()
    {
        var liveConnectorSinkConfigurationResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration();

        return liveConnectorSinkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration result)
    {
        base.CreateChildren(result);

        result.RTMPConfiguration ??= RTMPConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration(this InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null)
    {
        parentFactory.RTMPConfigurationFactory = new InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RTMPConfigurationFactory);
    }

    public static CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1>(this CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2>(this CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T2, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, T2, T3, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3>(this CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T2, T3, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T3, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, T2, T3, T4, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T2, T3, T4, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T3, T4, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T4, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory, InnerMediaLiveConnectorPipelineLiveConnectorRTMPConfigurationFactory> WithRTMPConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaLiveConnectorPipelineLiveConnectorSinkConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRTMPConfiguration(combinedResult.T5, subFactoryAction).T2);
}
