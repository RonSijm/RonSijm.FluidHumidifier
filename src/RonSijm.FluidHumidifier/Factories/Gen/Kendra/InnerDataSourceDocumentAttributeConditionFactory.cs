// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceDocumentAttributeConditionFactory(Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition>
{

    internal InnerDataSourceDocumentAttributeValueFactory ConditionOnValueFactory { get; set; }

    protected override Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition Create()
    {
        var documentAttributeConditionResult = CreateDocumentAttributeCondition();
        factoryAction?.Invoke(documentAttributeConditionResult);

        return documentAttributeConditionResult;
    }

    private Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition CreateDocumentAttributeCondition()
    {
        var documentAttributeConditionResult = new Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition();

        return documentAttributeConditionResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSourceTypes.DocumentAttributeCondition result)
    {
        base.CreateChildren(result);

        result.ConditionOnValue ??= ConditionOnValueFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDocumentAttributeConditionFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue(this InnerDataSourceDocumentAttributeConditionFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null)
    {
        parentFactory.ConditionOnValueFactory = new InnerDataSourceDocumentAttributeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionOnValueFactory);
    }

    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditionOnValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditionOnValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3, T4, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3, T4, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3, T4, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory, T4, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithConditionOnValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionOnValue(combinedResult.T5, subFactoryAction));
}
