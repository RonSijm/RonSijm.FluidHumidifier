// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceDocumentAttributeConditionFactory(Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition>
{

    internal InnerDataSourceDocumentAttributeValueFactory ValueFactory { get; set; }

    protected override Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition Create()
    {
        var documentAttributeConditionResult = CreateDocumentAttributeCondition();
        factoryAction?.Invoke(documentAttributeConditionResult);

        return documentAttributeConditionResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition CreateDocumentAttributeCondition()
    {
        var documentAttributeConditionResult = new Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition();

        return documentAttributeConditionResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition result)
    {
        base.CreateChildren(result);

        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDocumentAttributeConditionFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithValue(this InnerDataSourceDocumentAttributeConditionFactory parentFactory, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerDataSourceDocumentAttributeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3, T4, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDocumentAttributeConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3, T4, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDocumentAttributeConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3, T4, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDocumentAttributeConditionFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory, T4, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDocumentAttributeConditionFactory, InnerDataSourceDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDocumentAttributeConditionFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction));
}
