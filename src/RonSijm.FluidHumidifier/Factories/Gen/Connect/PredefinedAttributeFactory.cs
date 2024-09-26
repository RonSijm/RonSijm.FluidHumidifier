// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class PredefinedAttributeFactory(string resourceName = null, Action<Humidifier.Connect.PredefinedAttribute> factoryAction = null) : ResourceFactory<Humidifier.Connect.PredefinedAttribute>(resourceName)
{

    internal InnerPredefinedAttributeValuesFactory ValuesFactory { get; set; }

    protected override Humidifier.Connect.PredefinedAttribute Create()
    {
        var predefinedAttributeResult = CreatePredefinedAttribute();
        factoryAction?.Invoke(predefinedAttributeResult);

        return predefinedAttributeResult;
    }

    private Humidifier.Connect.PredefinedAttribute CreatePredefinedAttribute()
    {
        var predefinedAttributeResult = new Humidifier.Connect.PredefinedAttribute
        {
            GivenName = InputResourceName,
        };

        return predefinedAttributeResult;
    }
    public override void CreateChildren(Humidifier.Connect.PredefinedAttribute result)
    {
        base.CreateChildren(result);

        result.Values ??= ValuesFactory?.Build();
    }

} // End Of Class

public static class PredefinedAttributeFactoryExtensions
{
    public static CombinedResult<PredefinedAttributeFactory, InnerPredefinedAttributeValuesFactory> WithValues(this PredefinedAttributeFactory parentFactory, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null)
    {
        parentFactory.ValuesFactory = new InnerPredefinedAttributeValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValuesFactory);
    }

    public static CombinedResult<PredefinedAttributeFactory, T1, InnerPredefinedAttributeValuesFactory> WithValues<T1>(this CombinedResult<PredefinedAttributeFactory, T1> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PredefinedAttributeFactory, InnerPredefinedAttributeValuesFactory> WithValues<T1>(this CombinedResult<T1, PredefinedAttributeFactory> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PredefinedAttributeFactory, T1, T2, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2>(this CombinedResult<PredefinedAttributeFactory, T1, T2> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PredefinedAttributeFactory, T2, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2>(this CombinedResult<T1, PredefinedAttributeFactory, T2> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PredefinedAttributeFactory, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2>(this CombinedResult<T1, T2, PredefinedAttributeFactory> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PredefinedAttributeFactory, T1, T2, T3, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<PredefinedAttributeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PredefinedAttributeFactory, T2, T3, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, PredefinedAttributeFactory, T2, T3> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PredefinedAttributeFactory, T3, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, T2, PredefinedAttributeFactory, T3> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PredefinedAttributeFactory, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, PredefinedAttributeFactory> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PredefinedAttributeFactory, T1, T2, T3, T4, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<PredefinedAttributeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PredefinedAttributeFactory, T2, T3, T4, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, PredefinedAttributeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PredefinedAttributeFactory, T3, T4, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, PredefinedAttributeFactory, T3, T4> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PredefinedAttributeFactory, T4, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PredefinedAttributeFactory, T4> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PredefinedAttributeFactory, InnerPredefinedAttributeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PredefinedAttributeFactory> combinedResult, Action<Humidifier.Connect.PredefinedAttributeTypes.Values> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T5, subFactoryAction));
}
