// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetIntegerDatasetParameterFactory(Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter>
{

    internal InnerDataSetIntegerDatasetParameterDefaultValuesFactory DefaultValuesFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter Create()
    {
        var integerDatasetParameterResult = CreateIntegerDatasetParameter();
        factoryAction?.Invoke(integerDatasetParameterResult);

        return integerDatasetParameterResult;
    }

    private Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter CreateIntegerDatasetParameter()
    {
        var integerDatasetParameterResult = new Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter();

        return integerDatasetParameterResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter result)
    {
        base.CreateChildren(result);

        result.DefaultValues ??= DefaultValuesFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetIntegerDatasetParameterFactoryExtensions
{
    public static CombinedResult<InnerDataSetIntegerDatasetParameterFactory, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues(this InnerDataSetIntegerDatasetParameterFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null)
    {
        parentFactory.DefaultValuesFactory = new InnerDataSetIntegerDatasetParameterDefaultValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultValuesFactory);
    }

    public static CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, T2, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, T2, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetIntegerDatasetParameterFactory, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, T2, InnerDataSetIntegerDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, T2, T3, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, T2, T3, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetIntegerDatasetParameterFactory, T3, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetIntegerDatasetParameterFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetIntegerDatasetParameterFactory, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetIntegerDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, T2, T3, T4, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<InnerDataSetIntegerDatasetParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, T2, T3, T4, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetIntegerDatasetParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetIntegerDatasetParameterFactory, T3, T4, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetIntegerDatasetParameterFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetIntegerDatasetParameterFactory, T4, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetIntegerDatasetParameterFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetIntegerDatasetParameterFactory, InnerDataSetIntegerDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetIntegerDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T5, subFactoryAction));
}
