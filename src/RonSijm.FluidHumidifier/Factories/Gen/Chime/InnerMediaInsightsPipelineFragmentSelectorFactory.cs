// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineFragmentSelectorFactory(Action<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector>
{

    internal InnerMediaInsightsPipelineTimestampRangeFactory TimestampRangeFactory { get; set; }

    protected override Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector Create()
    {
        var fragmentSelectorResult = CreateFragmentSelector();
        factoryAction?.Invoke(fragmentSelectorResult);

        return fragmentSelectorResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector CreateFragmentSelector()
    {
        var fragmentSelectorResult = new Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector();

        return fragmentSelectorResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector result)
    {
        base.CreateChildren(result);

        result.TimestampRange ??= TimestampRangeFactory?.Build();
    }

} // End Of Class

public static class InnerMediaInsightsPipelineFragmentSelectorFactoryExtensions
{
    public static CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange(this InnerMediaInsightsPipelineFragmentSelectorFactory parentFactory, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null)
    {
        parentFactory.TimestampRangeFactory = new InnerMediaInsightsPipelineTimestampRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimestampRangeFactory);
    }

    public static CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1>(this CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestampRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1>(this CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestampRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, T2, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2>(this CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, T2, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2>(this CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, T2> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2>(this CombinedResult<T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, T2, T3, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3>(this CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, T2, T3, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3>(this CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory, T3, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory, T3> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineFragmentSelectorFactory, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineFragmentSelectorFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, T2, T3, T4, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3, T4>(this CombinedResult<InnerMediaInsightsPipelineFragmentSelectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, T2, T3, T4, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaInsightsPipelineFragmentSelectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory, T3, T4, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaInsightsPipelineFragmentSelectorFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineFragmentSelectorFactory, T4, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaInsightsPipelineFragmentSelectorFactory, T4> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaInsightsPipelineFragmentSelectorFactory, InnerMediaInsightsPipelineTimestampRangeFactory> WithTimestampRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaInsightsPipelineFragmentSelectorFactory> combinedResult, Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampRange(combinedResult.T5, subFactoryAction).T2);
}
