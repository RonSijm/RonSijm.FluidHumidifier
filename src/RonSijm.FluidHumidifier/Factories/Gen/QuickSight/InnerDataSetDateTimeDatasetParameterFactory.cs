// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDateTimeDatasetParameterFactory(Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter>
{

    internal InnerDataSetDateTimeDatasetParameterDefaultValuesFactory DefaultValuesFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter Create()
    {
        var dateTimeDatasetParameterResult = CreateDateTimeDatasetParameter();
        factoryAction?.Invoke(dateTimeDatasetParameterResult);

        return dateTimeDatasetParameterResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter CreateDateTimeDatasetParameter()
    {
        var dateTimeDatasetParameterResult = new Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter();

        return dateTimeDatasetParameterResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter result)
    {
        base.CreateChildren(result);

        result.DefaultValues ??= DefaultValuesFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetDateTimeDatasetParameterFactoryExtensions
{
    public static CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues(this InnerDataSetDateTimeDatasetParameterFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null)
    {
        parentFactory.DefaultValuesFactory = new InnerDataSetDateTimeDatasetParameterDefaultValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultValuesFactory);
    }

    public static CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, T2, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, T2, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDateTimeDatasetParameterFactory, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, T2, InnerDataSetDateTimeDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, T2, T3, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, T2, T3, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDateTimeDatasetParameterFactory, T3, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetDateTimeDatasetParameterFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetDateTimeDatasetParameterFactory, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetDateTimeDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, T2, T3, T4, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<InnerDataSetDateTimeDatasetParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, T2, T3, T4, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetDateTimeDatasetParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetDateTimeDatasetParameterFactory, T3, T4, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetDateTimeDatasetParameterFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetDateTimeDatasetParameterFactory, T4, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetDateTimeDatasetParameterFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetDateTimeDatasetParameterFactory, InnerDataSetDateTimeDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetDateTimeDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T5, subFactoryAction));
}
