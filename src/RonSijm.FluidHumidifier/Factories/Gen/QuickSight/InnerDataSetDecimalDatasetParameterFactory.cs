// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDecimalDatasetParameterFactory(Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter>
{

    internal InnerDataSetDecimalDatasetParameterDefaultValuesFactory DefaultValuesFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter Create()
    {
        var decimalDatasetParameterResult = CreateDecimalDatasetParameter();
        factoryAction?.Invoke(decimalDatasetParameterResult);

        return decimalDatasetParameterResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter CreateDecimalDatasetParameter()
    {
        var decimalDatasetParameterResult = new Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter();

        return decimalDatasetParameterResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter result)
    {
        base.CreateChildren(result);

        result.DefaultValues ??= DefaultValuesFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetDecimalDatasetParameterFactoryExtensions
{
    public static CombinedResult<InnerDataSetDecimalDatasetParameterFactory, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues(this InnerDataSetDecimalDatasetParameterFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null)
    {
        parentFactory.DefaultValuesFactory = new InnerDataSetDecimalDatasetParameterDefaultValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultValuesFactory);
    }

    public static CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, T2, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, T2, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDecimalDatasetParameterFactory, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, T2, InnerDataSetDecimalDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, T2, T3, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, T2, T3, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDecimalDatasetParameterFactory, T3, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetDecimalDatasetParameterFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetDecimalDatasetParameterFactory, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetDecimalDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, T2, T3, T4, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<InnerDataSetDecimalDatasetParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, T2, T3, T4, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetDecimalDatasetParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDecimalDatasetParameterFactory, T3, T4, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetDecimalDatasetParameterFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetDecimalDatasetParameterFactory, T4, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetDecimalDatasetParameterFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetDecimalDatasetParameterFactory, InnerDataSetDecimalDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetDecimalDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T5, subFactoryAction));
}
