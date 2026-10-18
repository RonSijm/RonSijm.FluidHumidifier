// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerFieldFieldAttributesFactory(Action<Humidifier.Cases.FieldTypes.FieldAttributes> factoryAction = null) : SubResourceFactory<Humidifier.Cases.FieldTypes.FieldAttributes>
{

    internal InnerFieldTextAttributesFactory TextFactory { get; set; }

    protected override Humidifier.Cases.FieldTypes.FieldAttributes Create()
    {
        var fieldAttributesResult = CreateFieldAttributes();
        factoryAction?.Invoke(fieldAttributesResult);

        return fieldAttributesResult;
    }

    private Humidifier.Cases.FieldTypes.FieldAttributes CreateFieldAttributes()
    {
        var fieldAttributesResult = new Humidifier.Cases.FieldTypes.FieldAttributes();

        return fieldAttributesResult;
    }
    public override void CreateChildren(Humidifier.Cases.FieldTypes.FieldAttributes result)
    {
        base.CreateChildren(result);

        result.Text ??= TextFactory?.Build();
    }

} // End Of Class

public static class InnerFieldFieldAttributesFactoryExtensions
{
    public static CombinedResult<InnerFieldFieldAttributesFactory, InnerFieldTextAttributesFactory> WithText(this InnerFieldFieldAttributesFactory parentFactory, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null)
    {
        parentFactory.TextFactory = new InnerFieldTextAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TextFactory);
    }

    public static CombinedResult<InnerFieldFieldAttributesFactory, T1, InnerFieldTextAttributesFactory> WithText<T1>(this CombinedResult<InnerFieldFieldAttributesFactory, T1> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFieldFieldAttributesFactory, InnerFieldTextAttributesFactory> WithText<T1>(this CombinedResult<T1, InnerFieldFieldAttributesFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFieldFieldAttributesFactory, T1, T2, InnerFieldTextAttributesFactory> WithText<T1, T2>(this CombinedResult<InnerFieldFieldAttributesFactory, T1, T2> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFieldFieldAttributesFactory, T2, InnerFieldTextAttributesFactory> WithText<T1, T2>(this CombinedResult<T1, InnerFieldFieldAttributesFactory, T2> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFieldFieldAttributesFactory, InnerFieldTextAttributesFactory> WithText<T1, T2>(this CombinedResult<T1, T2, InnerFieldFieldAttributesFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFieldFieldAttributesFactory, T1, T2, T3, InnerFieldTextAttributesFactory> WithText<T1, T2, T3>(this CombinedResult<InnerFieldFieldAttributesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFieldFieldAttributesFactory, T2, T3, InnerFieldTextAttributesFactory> WithText<T1, T2, T3>(this CombinedResult<T1, InnerFieldFieldAttributesFactory, T2, T3> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFieldFieldAttributesFactory, T3, InnerFieldTextAttributesFactory> WithText<T1, T2, T3>(this CombinedResult<T1, T2, InnerFieldFieldAttributesFactory, T3> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFieldFieldAttributesFactory, InnerFieldTextAttributesFactory> WithText<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFieldFieldAttributesFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFieldFieldAttributesFactory, T1, T2, T3, T4, InnerFieldTextAttributesFactory> WithText<T1, T2, T3, T4>(this CombinedResult<InnerFieldFieldAttributesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFieldFieldAttributesFactory, T2, T3, T4, InnerFieldTextAttributesFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, InnerFieldFieldAttributesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFieldFieldAttributesFactory, T3, T4, InnerFieldTextAttributesFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFieldFieldAttributesFactory, T3, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFieldFieldAttributesFactory, T4, InnerFieldTextAttributesFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFieldFieldAttributesFactory, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFieldFieldAttributesFactory, InnerFieldTextAttributesFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFieldFieldAttributesFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.TextAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T5, subFactoryAction).T2);
}
