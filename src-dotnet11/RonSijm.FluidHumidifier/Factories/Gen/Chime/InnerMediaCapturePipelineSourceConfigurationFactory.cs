// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineSourceConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration>
{

    internal InnerMediaCapturePipelineSelectedVideoStreamsFactory SelectedVideoStreamsFactory { get; set; }

    protected override Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration Create()
    {
        var sourceConfigurationResult = CreateSourceConfiguration();
        factoryAction?.Invoke(sourceConfigurationResult);

        return sourceConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration CreateSourceConfiguration()
    {
        var sourceConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration();

        return sourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration result)
    {
        base.CreateChildren(result);

        result.SelectedVideoStreams ??= SelectedVideoStreamsFactory?.Build();
    }

} // End Of Class

public static class InnerMediaCapturePipelineSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams(this InnerMediaCapturePipelineSourceConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null)
    {
        parentFactory.SelectedVideoStreamsFactory = new InnerMediaCapturePipelineSelectedVideoStreamsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelectedVideoStreamsFactory);
    }

    public static CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1>(this CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1>(this CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, T2, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2>(this CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, T2, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2>(this CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaCapturePipelineSourceConfigurationFactory, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2>(this CombinedResult<T1, T2, InnerMediaCapturePipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, T2, T3, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, T2, T3, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaCapturePipelineSourceConfigurationFactory, T3, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaCapturePipelineSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaCapturePipelineSourceConfigurationFactory, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaCapturePipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, T2, T3, T4, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<InnerMediaCapturePipelineSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, T2, T3, T4, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaCapturePipelineSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaCapturePipelineSourceConfigurationFactory, T3, T4, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaCapturePipelineSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaCapturePipelineSourceConfigurationFactory, T4, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaCapturePipelineSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaCapturePipelineSourceConfigurationFactory, InnerMediaCapturePipelineSelectedVideoStreamsFactory> WithSelectedVideoStreams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaCapturePipelineSourceConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectedVideoStreams(combinedResult.T5, subFactoryAction).T2);
}
