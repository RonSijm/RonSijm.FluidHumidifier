// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetStringDatasetParameterFactory(Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameter> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.StringDatasetParameter>
{

    internal InnerDataSetStringDatasetParameterDefaultValuesFactory DefaultValuesFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.StringDatasetParameter Create()
    {
        var stringDatasetParameterResult = CreateStringDatasetParameter();
        factoryAction?.Invoke(stringDatasetParameterResult);

        return stringDatasetParameterResult;
    }

    private Humidifier.QuickSight.DataSetTypes.StringDatasetParameter CreateStringDatasetParameter()
    {
        var stringDatasetParameterResult = new Humidifier.QuickSight.DataSetTypes.StringDatasetParameter();

        return stringDatasetParameterResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.StringDatasetParameter result)
    {
        base.CreateChildren(result);

        result.DefaultValues ??= DefaultValuesFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetStringDatasetParameterFactoryExtensions
{
    public static CombinedResult<InnerDataSetStringDatasetParameterFactory, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues(this InnerDataSetStringDatasetParameterFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null)
    {
        parentFactory.DefaultValuesFactory = new InnerDataSetStringDatasetParameterDefaultValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultValuesFactory);
    }

    public static CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<InnerDataSetStringDatasetParameterFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1>(this CombinedResult<T1, InnerDataSetStringDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, T2, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, T2, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetStringDatasetParameterFactory, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2>(this CombinedResult<T1, T2, InnerDataSetStringDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, T2, T3, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, T2, T3, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetStringDatasetParameterFactory, T3, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetStringDatasetParameterFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetStringDatasetParameterFactory, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetStringDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, T2, T3, T4, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<InnerDataSetStringDatasetParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, T2, T3, T4, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetStringDatasetParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetStringDatasetParameterFactory, T3, T4, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetStringDatasetParameterFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetStringDatasetParameterFactory, T4, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetStringDatasetParameterFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetStringDatasetParameterFactory, InnerDataSetStringDatasetParameterDefaultValuesFactory> WithDefaultValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetStringDatasetParameterFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValues(combinedResult.T5, subFactoryAction));
}
