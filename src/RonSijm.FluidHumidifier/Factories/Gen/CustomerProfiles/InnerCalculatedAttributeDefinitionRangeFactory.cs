// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerCalculatedAttributeDefinitionRangeFactory(Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range>
{

    internal InnerCalculatedAttributeDefinitionValueRangeFactory ValueRangeFactory { get; set; }

    protected override Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range Create()
    {
        var rangeResult = CreateRange();
        factoryAction?.Invoke(rangeResult);

        return rangeResult;
    }

    private Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range CreateRange()
    {
        var rangeResult = new Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range();

        return rangeResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range result)
    {
        base.CreateChildren(result);

        result.ValueRange ??= ValueRangeFactory?.Build();
    }

} // End Of Class

public static class InnerCalculatedAttributeDefinitionRangeFactoryExtensions
{
    public static CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange(this InnerCalculatedAttributeDefinitionRangeFactory parentFactory, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null)
    {
        parentFactory.ValueRangeFactory = new InnerCalculatedAttributeDefinitionValueRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueRangeFactory);
    }

    public static CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1>(this CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithValueRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1>(this CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithValueRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, T2, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2>(this CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, T2, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2>(this CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCalculatedAttributeDefinitionRangeFactory, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2>(this CombinedResult<T1, T2, InnerCalculatedAttributeDefinitionRangeFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, T2, T3, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3>(this CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, T2, T3, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3>(this CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCalculatedAttributeDefinitionRangeFactory, T3, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerCalculatedAttributeDefinitionRangeFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCalculatedAttributeDefinitionRangeFactory, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCalculatedAttributeDefinitionRangeFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, T2, T3, T4, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3, T4>(this CombinedResult<InnerCalculatedAttributeDefinitionRangeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, T2, T3, T4, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerCalculatedAttributeDefinitionRangeFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCalculatedAttributeDefinitionRangeFactory, T3, T4, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCalculatedAttributeDefinitionRangeFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCalculatedAttributeDefinitionRangeFactory, T4, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCalculatedAttributeDefinitionRangeFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCalculatedAttributeDefinitionRangeFactory, InnerCalculatedAttributeDefinitionValueRangeFactory> WithValueRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCalculatedAttributeDefinitionRangeFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValueRange(combinedResult.T5, subFactoryAction).T2);
}
