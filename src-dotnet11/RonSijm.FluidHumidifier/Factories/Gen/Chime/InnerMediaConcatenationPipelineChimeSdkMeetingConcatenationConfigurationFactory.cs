// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration>
{

    internal InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory ArtifactsConfigurationFactory { get; set; }

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration Create()
    {
        var chimeSdkMeetingConcatenationConfigurationResult = CreateChimeSdkMeetingConcatenationConfiguration();
        factoryAction?.Invoke(chimeSdkMeetingConcatenationConfigurationResult);

        return chimeSdkMeetingConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration CreateChimeSdkMeetingConcatenationConfiguration()
    {
        var chimeSdkMeetingConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration();

        return chimeSdkMeetingConcatenationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration result)
    {
        base.CreateChildren(result);

        result.ArtifactsConfiguration ??= ArtifactsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration(this InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null)
    {
        parentFactory.ArtifactsConfigurationFactory = new InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArtifactsConfigurationFactory);
    }

    public static CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1>(this CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1>(this CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, T2, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2>(this CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T2, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2>(this CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, T2, T3, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3>(this CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T2, T3, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T3, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, T2, T3, T4, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T2, T3, T4, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T3, T4, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T4, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory, InnerMediaConcatenationPipelineArtifactsConcatenationConfigurationFactory> WithArtifactsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaConcatenationPipelineChimeSdkMeetingConcatenationConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactsConfiguration(combinedResult.T5, subFactoryAction).T2);
}
