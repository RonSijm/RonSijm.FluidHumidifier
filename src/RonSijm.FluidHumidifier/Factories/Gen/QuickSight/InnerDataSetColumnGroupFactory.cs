// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetColumnGroupFactory(Action<Humidifier.QuickSight.DataSetTypes.ColumnGroup> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.ColumnGroup>
{

    internal InnerDataSetGeoSpatialColumnGroupFactory GeoSpatialColumnGroupFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.ColumnGroup Create()
    {
        var columnGroupResult = CreateColumnGroup();
        factoryAction?.Invoke(columnGroupResult);

        return columnGroupResult;
    }

    private Humidifier.QuickSight.DataSetTypes.ColumnGroup CreateColumnGroup()
    {
        var columnGroupResult = new Humidifier.QuickSight.DataSetTypes.ColumnGroup();

        return columnGroupResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.ColumnGroup result)
    {
        base.CreateChildren(result);

        result.GeoSpatialColumnGroup ??= GeoSpatialColumnGroupFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetColumnGroupFactoryExtensions
{
    public static CombinedResult<InnerDataSetColumnGroupFactory, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup(this InnerDataSetColumnGroupFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null)
    {
        parentFactory.GeoSpatialColumnGroupFactory = new InnerDataSetGeoSpatialColumnGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GeoSpatialColumnGroupFactory);
    }

    public static CombinedResult<InnerDataSetColumnGroupFactory, T1, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1>(this CombinedResult<InnerDataSetColumnGroupFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetColumnGroupFactory, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1>(this CombinedResult<T1, InnerDataSetColumnGroupFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetColumnGroupFactory, T1, T2, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2>(this CombinedResult<InnerDataSetColumnGroupFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetColumnGroupFactory, T2, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2>(this CombinedResult<T1, InnerDataSetColumnGroupFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetColumnGroupFactory, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2>(this CombinedResult<T1, T2, InnerDataSetColumnGroupFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetColumnGroupFactory, T1, T2, T3, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3>(this CombinedResult<InnerDataSetColumnGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetColumnGroupFactory, T2, T3, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3>(this CombinedResult<T1, InnerDataSetColumnGroupFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetColumnGroupFactory, T3, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetColumnGroupFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetColumnGroupFactory, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetColumnGroupFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetColumnGroupFactory, T1, T2, T3, T4, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3, T4>(this CombinedResult<InnerDataSetColumnGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetColumnGroupFactory, T2, T3, T4, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetColumnGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetColumnGroupFactory, T3, T4, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetColumnGroupFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetColumnGroupFactory, T4, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetColumnGroupFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetColumnGroupFactory, InnerDataSetGeoSpatialColumnGroupFactory> WithGeoSpatialColumnGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetColumnGroupFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoSpatialColumnGroup(combinedResult.T5, subFactoryAction));
}
