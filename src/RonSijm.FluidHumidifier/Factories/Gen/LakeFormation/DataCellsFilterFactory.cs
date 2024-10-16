// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class DataCellsFilterFactory(string resourceName = null, Action<Humidifier.LakeFormation.DataCellsFilter> factoryAction = null) : ResourceFactory<Humidifier.LakeFormation.DataCellsFilter>(resourceName)
{

    internal InnerDataCellsFilterRowFilterFactory RowFilterFactory { get; set; }

    internal InnerDataCellsFilterColumnWildcardFactory ColumnWildcardFactory { get; set; }

    protected override Humidifier.LakeFormation.DataCellsFilter Create()
    {
        var dataCellsFilterResult = CreateDataCellsFilter();
        factoryAction?.Invoke(dataCellsFilterResult);

        return dataCellsFilterResult;
    }

    private Humidifier.LakeFormation.DataCellsFilter CreateDataCellsFilter()
    {
        var dataCellsFilterResult = new Humidifier.LakeFormation.DataCellsFilter
        {
            GivenName = InputResourceName,
        };

        return dataCellsFilterResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.DataCellsFilter result)
    {
        base.CreateChildren(result);

        result.RowFilter ??= RowFilterFactory?.Build();
        result.ColumnWildcard ??= ColumnWildcardFactory?.Build();
    }

} // End Of Class

public static class DataCellsFilterFactoryExtensions
{
    public static CombinedResult<DataCellsFilterFactory, InnerDataCellsFilterRowFilterFactory> WithRowFilter(this DataCellsFilterFactory parentFactory, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null)
    {
        parentFactory.RowFilterFactory = new InnerDataCellsFilterRowFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RowFilterFactory);
    }

    public static CombinedResult<DataCellsFilterFactory, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard(this DataCellsFilterFactory parentFactory, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null)
    {
        parentFactory.ColumnWildcardFactory = new InnerDataCellsFilterColumnWildcardFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColumnWildcardFactory);
    }

    public static CombinedResult<DataCellsFilterFactory, T1, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1>(this CombinedResult<DataCellsFilterFactory, T1> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRowFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1>(this CombinedResult<T1, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRowFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, T2, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2>(this CombinedResult<DataCellsFilterFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, T2, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2>(this CombinedResult<T1, DataCellsFilterFactory, T2> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCellsFilterFactory, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2>(this CombinedResult<T1, T2, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, T2, T3, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3>(this CombinedResult<DataCellsFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, T2, T3, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3>(this CombinedResult<T1, DataCellsFilterFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCellsFilterFactory, T3, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3>(this CombinedResult<T1, T2, DataCellsFilterFactory, T3> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataCellsFilterFactory, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, T2, T3, T4, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3, T4>(this CombinedResult<DataCellsFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, T2, T3, T4, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3, T4>(this CombinedResult<T1, DataCellsFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCellsFilterFactory, T3, T4, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataCellsFilterFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataCellsFilterFactory, T4, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataCellsFilterFactory, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataCellsFilterFactory, InnerDataCellsFilterRowFilterFactory> WithRowFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRowFilter(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1>(this CombinedResult<DataCellsFilterFactory, T1> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1>(this CombinedResult<T1, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, T2, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<DataCellsFilterFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, T2, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<T1, DataCellsFilterFactory, T2> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCellsFilterFactory, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2>(this CombinedResult<T1, T2, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, T2, T3, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<DataCellsFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, T2, T3, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, DataCellsFilterFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCellsFilterFactory, T3, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, T2, DataCellsFilterFactory, T3> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataCellsFilterFactory, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataCellsFilterFactory, T1, T2, T3, T4, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<DataCellsFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCellsFilterFactory, T2, T3, T4, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, DataCellsFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCellsFilterFactory, T3, T4, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataCellsFilterFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataCellsFilterFactory, T4, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataCellsFilterFactory, T4> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataCellsFilterFactory, InnerDataCellsFilterColumnWildcardFactory> WithColumnWildcard<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataCellsFilterFactory> combinedResult, Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnWildcard(combinedResult.T5, subFactoryAction));
}
