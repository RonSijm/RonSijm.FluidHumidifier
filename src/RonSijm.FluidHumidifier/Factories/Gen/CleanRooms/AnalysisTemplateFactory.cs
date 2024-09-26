// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class AnalysisTemplateFactory(string resourceName = null, Action<Humidifier.CleanRooms.AnalysisTemplate> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.AnalysisTemplate>(resourceName)
{

    internal List<InnerAnalysisTemplateAnalysisParameterFactory> AnalysisParametersFactories { get; set; } = [];

    internal InnerAnalysisTemplateAnalysisSourceFactory SourceFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplate Create()
    {
        var analysisTemplateResult = CreateAnalysisTemplate();
        factoryAction?.Invoke(analysisTemplateResult);

        return analysisTemplateResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplate CreateAnalysisTemplate()
    {
        var analysisTemplateResult = new Humidifier.CleanRooms.AnalysisTemplate
        {
            GivenName = InputResourceName,
        };

        return analysisTemplateResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplate result)
    {
        base.CreateChildren(result);

        result.AnalysisParameters = AnalysisParametersFactories.Any() ? AnalysisParametersFactories.Select(x => x.Build()).ToList() : null;
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class AnalysisTemplateFactoryExtensions
{
    public static CombinedResult<AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters(this AnalysisTemplateFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null)
    {
        var factory = new InnerAnalysisTemplateAnalysisParameterFactory(subFactoryAction);
        parentFactory.AnalysisParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisSourceFactory> WithSource(this AnalysisTemplateFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerAnalysisTemplateAnalysisSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<AnalysisTemplateFactory, T1, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1>(this CombinedResult<AnalysisTemplateFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1>(this CombinedResult<T1, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, T2, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2>(this CombinedResult<AnalysisTemplateFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, T2, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2>(this CombinedResult<T1, AnalysisTemplateFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2>(this CombinedResult<T1, T2, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, T2, T3, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3>(this CombinedResult<AnalysisTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, T2, T3, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3>(this CombinedResult<T1, AnalysisTemplateFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalysisTemplateFactory, T3, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3>(this CombinedResult<T1, T2, AnalysisTemplateFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, T2, T3, T4, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3, T4>(this CombinedResult<AnalysisTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, T2, T3, T4, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3, T4>(this CombinedResult<T1, AnalysisTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalysisTemplateFactory, T3, T4, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnalysisTemplateFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalysisTemplateFactory, T4, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnalysisTemplateFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisParameterFactory> WithAnalysisParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1>(this CombinedResult<AnalysisTemplateFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1>(this CombinedResult<T1, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, T2, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2>(this CombinedResult<AnalysisTemplateFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, T2, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, AnalysisTemplateFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, T2, T3, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<AnalysisTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, T2, T3, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, AnalysisTemplateFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalysisTemplateFactory, T3, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, AnalysisTemplateFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnalysisTemplateFactory, T1, T2, T3, T4, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<AnalysisTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalysisTemplateFactory, T2, T3, T4, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, AnalysisTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalysisTemplateFactory, T3, T4, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnalysisTemplateFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalysisTemplateFactory, T4, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnalysisTemplateFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnalysisTemplateFactory, InnerAnalysisTemplateAnalysisSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnalysisTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction));
}
