// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class DataTableAttributeFactory(string resourceName = null, Action<Humidifier.Connect.DataTableAttribute> factoryAction = null) : ResourceFactory<Humidifier.Connect.DataTableAttribute>(resourceName)
{

    internal InnerDataTableAttributeValidationFactory ValidationFactory { get; set; }

    protected override Humidifier.Connect.DataTableAttribute Create()
    {
        var dataTableAttributeResult = CreateDataTableAttribute();
        factoryAction?.Invoke(dataTableAttributeResult);

        return dataTableAttributeResult;
    }

    private Humidifier.Connect.DataTableAttribute CreateDataTableAttribute()
    {
        var dataTableAttributeResult = new Humidifier.Connect.DataTableAttribute
        {
            GivenName = InputResourceName,
        };

        return dataTableAttributeResult;
    }
    public override void CreateChildren(Humidifier.Connect.DataTableAttribute result)
    {
        base.CreateChildren(result);

        result.Validation ??= ValidationFactory?.Build();
    }

} // End Of Class

public static class DataTableAttributeFactoryExtensions
{
    public static CombinedResult<DataTableAttributeFactory, InnerDataTableAttributeValidationFactory> WithValidation(this DataTableAttributeFactory parentFactory, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null)
    {
        parentFactory.ValidationFactory = new InnerDataTableAttributeValidationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidationFactory);
    }

    public static CombinedResult<DataTableAttributeFactory, T1, InnerDataTableAttributeValidationFactory> WithValidation<T1>(this CombinedResult<DataTableAttributeFactory, T1> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableAttributeFactory, InnerDataTableAttributeValidationFactory> WithValidation<T1>(this CombinedResult<T1, DataTableAttributeFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataTableAttributeFactory, T1, T2, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2>(this CombinedResult<DataTableAttributeFactory, T1, T2> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableAttributeFactory, T2, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2>(this CombinedResult<T1, DataTableAttributeFactory, T2> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTableAttributeFactory, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2>(this CombinedResult<T1, T2, DataTableAttributeFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataTableAttributeFactory, T1, T2, T3, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<DataTableAttributeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableAttributeFactory, T2, T3, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, DataTableAttributeFactory, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTableAttributeFactory, T3, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, T2, DataTableAttributeFactory, T3> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataTableAttributeFactory, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataTableAttributeFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataTableAttributeFactory, T1, T2, T3, T4, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<DataTableAttributeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableAttributeFactory, T2, T3, T4, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, DataTableAttributeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTableAttributeFactory, T3, T4, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataTableAttributeFactory, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataTableAttributeFactory, T4, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataTableAttributeFactory, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataTableAttributeFactory, InnerDataTableAttributeValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataTableAttributeFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Validation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T5, subFactoryAction).T2);
}
