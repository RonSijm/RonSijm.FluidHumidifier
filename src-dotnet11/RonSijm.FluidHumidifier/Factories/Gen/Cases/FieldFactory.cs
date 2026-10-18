// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class FieldFactory(string resourceName = null, Action<Humidifier.Cases.Field> factoryAction = null) : ResourceFactory<Humidifier.Cases.Field>(resourceName)
{

    internal InnerFieldFieldAttributesFactory Attributes_Factory { get; set; }

    protected override Humidifier.Cases.Field Create()
    {
        var fieldResult = CreateField();
        factoryAction?.Invoke(fieldResult);

        return fieldResult;
    }

    private Humidifier.Cases.Field CreateField()
    {
        var fieldResult = new Humidifier.Cases.Field
        {
            GivenName = InputResourceName,
        };

        return fieldResult;
    }
    public override void CreateChildren(Humidifier.Cases.Field result)
    {
        base.CreateChildren(result);

        result.Attributes_ ??= Attributes_Factory?.Build();
    }

} // End Of Class

public static class FieldFactoryExtensions
{
    public static CombinedResult<FieldFactory, InnerFieldFieldAttributesFactory> WithAttributes_(this FieldFactory parentFactory, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null)
    {
        parentFactory.Attributes_Factory = new InnerFieldFieldAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Attributes_Factory);
    }

    public static CombinedResult<FieldFactory, T1, InnerFieldFieldAttributesFactory> WithAttributes_<T1>(this CombinedResult<FieldFactory, T1> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldFactory, InnerFieldFieldAttributesFactory> WithAttributes_<T1>(this CombinedResult<T1, FieldFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FieldFactory, T1, T2, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<FieldFactory, T1, T2> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldFactory, T2, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, FieldFactory, T2> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FieldFactory, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, T2, FieldFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FieldFactory, T1, T2, T3, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<FieldFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldFactory, T2, T3, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, FieldFactory, T2, T3> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FieldFactory, T3, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, FieldFactory, T3> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FieldFactory, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, T3, FieldFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FieldFactory, T1, T2, T3, T4, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<FieldFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldFactory, T2, T3, T4, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, FieldFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FieldFactory, T3, T4, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, FieldFactory, T3, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FieldFactory, T4, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FieldFactory, T4> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FieldFactory, InnerFieldFieldAttributesFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FieldFactory> combinedResult, Action<Humidifier.Cases.FieldTypes.FieldAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T5, subFactoryAction).T2);
}
