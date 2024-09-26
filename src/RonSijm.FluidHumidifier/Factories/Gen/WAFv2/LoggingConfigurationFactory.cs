// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class LoggingConfigurationFactory(string resourceName = null, Action<Humidifier.WAFv2.LoggingConfiguration> factoryAction = null) : ResourceFactory<Humidifier.WAFv2.LoggingConfiguration>(resourceName)
{

    internal List<InnerLoggingConfigurationFieldToMatchFactory> RedactedFieldsFactories { get; set; } = [];

    internal InnerLoggingConfigurationLoggingFilterFactory LoggingFilterFactory { get; set; }

    protected override Humidifier.WAFv2.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.WAFv2.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.WAFv2.LoggingConfiguration
        {
            GivenName = InputResourceName,
        };

        return loggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.LoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.RedactedFields = RedactedFieldsFactories.Any() ? RedactedFieldsFactories.Select(x => x.Build()).ToList() : null;
        result.LoggingFilter ??= LoggingFilterFactory?.Build();
    }

} // End Of Class

public static class LoggingConfigurationFactoryExtensions
{
    public static CombinedResult<LoggingConfigurationFactory, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields(this LoggingConfigurationFactory parentFactory, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null)
    {
        var factory = new InnerLoggingConfigurationFieldToMatchFactory(subFactoryAction);
        parentFactory.RedactedFieldsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LoggingConfigurationFactory, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter(this LoggingConfigurationFactory parentFactory, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null)
    {
        parentFactory.LoggingFilterFactory = new InnerLoggingConfigurationLoggingFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingFilterFactory);
    }

    public static CombinedResult<LoggingConfigurationFactory, T1, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1>(this CombinedResult<LoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithRedactedFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1>(this CombinedResult<T1, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithRedactedFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2>(this CombinedResult<LoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2>(this CombinedResult<T1, LoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2>(this CombinedResult<T1, T2, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3, T4>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3, T4>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory, InnerLoggingConfigurationFieldToMatchFactory> WithRedactedFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedactedFields(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1>(this CombinedResult<LoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1>(this CombinedResult<T1, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<LoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<T1, LoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<T1, T2, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T5, subFactoryAction));
}
