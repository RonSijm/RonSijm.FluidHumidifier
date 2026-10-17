// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineConcatenationSourceFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource>
{

    internal InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory MediaCapturePipelineSourceConfigurationFactory { get; set; }

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource Create()
    {
        var concatenationSourceResult = CreateConcatenationSource();
        factoryAction?.Invoke(concatenationSourceResult);

        return concatenationSourceResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource CreateConcatenationSource()
    {
        var concatenationSourceResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource();

        return concatenationSourceResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource result)
    {
        base.CreateChildren(result);

        result.MediaCapturePipelineSourceConfiguration ??= MediaCapturePipelineSourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineConcatenationSourceFactoryExtensions
{
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration(this InnerMediaConcatenationPipelineConcatenationSourceFactory parentFactory, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.MediaCapturePipelineSourceConfigurationFactory = new InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MediaCapturePipelineSourceConfigurationFactory);
    }

    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, T2, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, T2, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, T2, T3, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, T2, T3, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory, T3, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, T2, T3, T4, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, T2, T3, T4, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory, T3, T4, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory, T4, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSourceFactory, InnerMediaConcatenationPipelineMediaCapturePipelineSourceConfigurationFactory> WithMediaCapturePipelineSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSourceFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaCapturePipelineSourceConfiguration(combinedResult.T5, subFactoryAction).T2);
}
