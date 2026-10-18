// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class InnerFeedGetOutputFactory(Action<Humidifier.ElementalInference.FeedTypes.GetOutput> factoryAction = null) : SubResourceFactory<Humidifier.ElementalInference.FeedTypes.GetOutput>
{

    internal InnerFeedOutputConfigFactory OutputConfigFactory { get; set; }

    protected override Humidifier.ElementalInference.FeedTypes.GetOutput Create()
    {
        var getOutputResult = CreateGetOutput();
        factoryAction?.Invoke(getOutputResult);

        return getOutputResult;
    }

    private Humidifier.ElementalInference.FeedTypes.GetOutput CreateGetOutput()
    {
        var getOutputResult = new Humidifier.ElementalInference.FeedTypes.GetOutput();

        return getOutputResult;
    }
    public override void CreateChildren(Humidifier.ElementalInference.FeedTypes.GetOutput result)
    {
        base.CreateChildren(result);

        result.OutputConfig ??= OutputConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFeedGetOutputFactoryExtensions
{
    public static CombinedResult<InnerFeedGetOutputFactory, InnerFeedOutputConfigFactory> WithOutputConfig(this InnerFeedGetOutputFactory parentFactory, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null)
    {
        parentFactory.OutputConfigFactory = new InnerFeedOutputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputConfigFactory);
    }

    public static CombinedResult<InnerFeedGetOutputFactory, T1, InnerFeedOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<InnerFeedGetOutputFactory, T1> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedGetOutputFactory, InnerFeedOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<T1, InnerFeedGetOutputFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFeedGetOutputFactory, T1, T2, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<InnerFeedGetOutputFactory, T1, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedGetOutputFactory, T2, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, InnerFeedGetOutputFactory, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedGetOutputFactory, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, T2, InnerFeedGetOutputFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFeedGetOutputFactory, T1, T2, T3, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<InnerFeedGetOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedGetOutputFactory, T2, T3, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, InnerFeedGetOutputFactory, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedGetOutputFactory, T3, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeedGetOutputFactory, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFeedGetOutputFactory, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeedGetOutputFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFeedGetOutputFactory, T1, T2, T3, T4, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<InnerFeedGetOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedGetOutputFactory, T2, T3, T4, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeedGetOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedGetOutputFactory, T3, T4, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeedGetOutputFactory, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFeedGetOutputFactory, T4, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeedGetOutputFactory, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFeedGetOutputFactory, InnerFeedOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeedGetOutputFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T5, subFactoryAction).T2);
}
