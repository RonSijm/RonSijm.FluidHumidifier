// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerLoggingConfigurationFieldToMatchFactory(Action<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch>
{

    internal InnerLoggingConfigurationSingleHeaderFactory SingleHeaderFactory { get; set; }

    protected override Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch();

        return fieldToMatchResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch result)
    {
        base.CreateChildren(result);

        result.SingleHeader ??= SingleHeaderFactory?.Build();
    }

} // End Of Class

public static class InnerLoggingConfigurationFieldToMatchFactoryExtensions
{
    public static CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader(this InnerLoggingConfigurationFieldToMatchFactory parentFactory, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null)
    {
        parentFactory.SingleHeaderFactory = new InnerLoggingConfigurationSingleHeaderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SingleHeaderFactory);
    }

    public static CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1>(this CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithSingleHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1>(this CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithSingleHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, T2, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2>(this CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, T2, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2>(this CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, T2> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggingConfigurationFieldToMatchFactory, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2>(this CombinedResult<T1, T2, InnerLoggingConfigurationFieldToMatchFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, T2, T3, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3>(this CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, T2, T3, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3>(this CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggingConfigurationFieldToMatchFactory, T3, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3>(this CombinedResult<T1, T2, InnerLoggingConfigurationFieldToMatchFactory, T3> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLoggingConfigurationFieldToMatchFactory, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLoggingConfigurationFieldToMatchFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, T2, T3, T4, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3, T4>(this CombinedResult<InnerLoggingConfigurationFieldToMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, T2, T3, T4, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3, T4>(this CombinedResult<T1, InnerLoggingConfigurationFieldToMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggingConfigurationFieldToMatchFactory, T3, T4, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLoggingConfigurationFieldToMatchFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLoggingConfigurationFieldToMatchFactory, T4, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLoggingConfigurationFieldToMatchFactory, T4> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLoggingConfigurationFieldToMatchFactory, InnerLoggingConfigurationSingleHeaderFactory> WithSingleHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLoggingConfigurationFieldToMatchFactory> combinedResult, Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleHeader(combinedResult.T5, subFactoryAction));
}
