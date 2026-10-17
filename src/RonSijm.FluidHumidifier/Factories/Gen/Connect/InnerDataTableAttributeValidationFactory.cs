// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerDataTableAttributeValidationFactory(Action<Humidifier.Connect.DataTableAttributeTypes.Validation> factoryAction = null) : SubResourceFactory<Humidifier.Connect.DataTableAttributeTypes.Validation>
{

    internal InnerDataTableAttributeEnumFactory EnumFactory { get; set; }

    protected override Humidifier.Connect.DataTableAttributeTypes.Validation Create()
    {
        var validationResult = CreateValidation();
        factoryAction?.Invoke(validationResult);

        return validationResult;
    }

    private Humidifier.Connect.DataTableAttributeTypes.Validation CreateValidation()
    {
        var validationResult = new Humidifier.Connect.DataTableAttributeTypes.Validation();

        return validationResult;
    }
    public override void CreateChildren(Humidifier.Connect.DataTableAttributeTypes.Validation result)
    {
        base.CreateChildren(result);

        result.Enum ??= EnumFactory?.Build();
    }

} // End Of Class

public static class InnerDataTableAttributeValidationFactoryExtensions
{
    public static CombinedResult<InnerDataTableAttributeValidationFactory, InnerDataTableAttributeEnumFactory> WithEnum(this InnerDataTableAttributeValidationFactory parentFactory, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null)
    {
        parentFactory.EnumFactory = new InnerDataTableAttributeEnumFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnumFactory);
    }

    public static CombinedResult<InnerDataTableAttributeValidationFactory, T1, InnerDataTableAttributeEnumFactory> WithEnum<T1>(this CombinedResult<InnerDataTableAttributeValidationFactory, T1> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnum(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableAttributeValidationFactory, InnerDataTableAttributeEnumFactory> WithEnum<T1>(this CombinedResult<T1, InnerDataTableAttributeValidationFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnum(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableAttributeValidationFactory, T1, T2, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2>(this CombinedResult<InnerDataTableAttributeValidationFactory, T1, T2> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableAttributeValidationFactory, T2, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2>(this CombinedResult<T1, InnerDataTableAttributeValidationFactory, T2> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableAttributeValidationFactory, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2>(this CombinedResult<T1, T2, InnerDataTableAttributeValidationFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableAttributeValidationFactory, T1, T2, T3, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3>(this CombinedResult<InnerDataTableAttributeValidationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableAttributeValidationFactory, T2, T3, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3>(this CombinedResult<T1, InnerDataTableAttributeValidationFactory, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableAttributeValidationFactory, T3, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataTableAttributeValidationFactory, T3> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataTableAttributeValidationFactory, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataTableAttributeValidationFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableAttributeValidationFactory, T1, T2, T3, T4, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3, T4>(this CombinedResult<InnerDataTableAttributeValidationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableAttributeValidationFactory, T2, T3, T4, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataTableAttributeValidationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableAttributeValidationFactory, T3, T4, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataTableAttributeValidationFactory, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataTableAttributeValidationFactory, T4, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataTableAttributeValidationFactory, T4> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataTableAttributeValidationFactory, InnerDataTableAttributeEnumFactory> WithEnum<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataTableAttributeValidationFactory> combinedResult, Action<Humidifier.Connect.DataTableAttributeTypes.Enum> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnum(combinedResult.T5, subFactoryAction).T2);
}
