// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorDocumentAttributeFactory(Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute>
{

    internal InnerDataAccessorDocumentAttributeValueFactory ValueFactory { get; set; }

    protected override Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute Create()
    {
        var documentAttributeResult = CreateDocumentAttribute();
        factoryAction?.Invoke(documentAttributeResult);

        return documentAttributeResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute CreateDocumentAttribute()
    {
        var documentAttributeResult = new Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute();

        return documentAttributeResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataAccessorTypes.DocumentAttribute result)
    {
        base.CreateChildren(result);

        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerDataAccessorDocumentAttributeFactoryExtensions
{
    public static CombinedResult<InnerDataAccessorDocumentAttributeFactory, InnerDataAccessorDocumentAttributeValueFactory> WithValue(this InnerDataAccessorDocumentAttributeFactory parentFactory, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerDataAccessorDocumentAttributeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1>(this CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1>(this CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, T2, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, T2, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorDocumentAttributeFactory, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerDataAccessorDocumentAttributeFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, T2, T3, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, T2, T3, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorDocumentAttributeFactory, T3, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAccessorDocumentAttributeFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataAccessorDocumentAttributeFactory, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAccessorDocumentAttributeFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, T2, T3, T4, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerDataAccessorDocumentAttributeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, T2, T3, T4, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAccessorDocumentAttributeFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorDocumentAttributeFactory, T3, T4, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAccessorDocumentAttributeFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataAccessorDocumentAttributeFactory, T4, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAccessorDocumentAttributeFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataAccessorDocumentAttributeFactory, InnerDataAccessorDocumentAttributeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAccessorDocumentAttributeFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction));
}
