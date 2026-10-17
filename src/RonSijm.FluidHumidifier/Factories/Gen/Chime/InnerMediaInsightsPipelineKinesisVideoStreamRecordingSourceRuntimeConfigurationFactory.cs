// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration>
{

    internal InnerMediaInsightsPipelineFragmentSelectorFactory FragmentSelectorFactory { get; set; }

    protected override Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration Create()
    {
        var kinesisVideoStreamRecordingSourceRuntimeConfigurationResult = CreateKinesisVideoStreamRecordingSourceRuntimeConfiguration();
        factoryAction?.Invoke(kinesisVideoStreamRecordingSourceRuntimeConfigurationResult);

        return kinesisVideoStreamRecordingSourceRuntimeConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration CreateKinesisVideoStreamRecordingSourceRuntimeConfiguration()
    {
        var kinesisVideoStreamRecordingSourceRuntimeConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration();

        return kinesisVideoStreamRecordingSourceRuntimeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration result)
    {
        base.CreateChildren(result);

        result.FragmentSelector ??= FragmentSelectorFactory?.Build();
    }

} // End Of Class

public static class InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector(this InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory parentFactory, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null)
    {
        parentFactory.FragmentSelectorFactory = new InnerMediaInsightsPipelineFragmentSelectorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FragmentSelectorFactory);
    }

    public static CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1>(this CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithFragmentSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1>(this CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithFragmentSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2>(this CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T2, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2>(this CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2>(this CombinedResult<T1, T2, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, T2, T3, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3>(this CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T2, T3, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3>(this CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T3, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, T2, T3, T4, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3, T4>(this CombinedResult<InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T2, T3, T4, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T3, T4, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T4, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory, InnerMediaInsightsPipelineFragmentSelectorFactory> WithFragmentSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaInsightsPipelineKinesisVideoStreamRecordingSourceRuntimeConfigurationFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFragmentSelector(combinedResult.T5, subFactoryAction).T2);
}
