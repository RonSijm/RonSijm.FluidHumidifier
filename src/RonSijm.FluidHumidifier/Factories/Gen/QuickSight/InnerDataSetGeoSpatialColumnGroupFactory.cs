// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetGeoSpatialColumnGroupFactory(Action<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup>
{

    protected override Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup Create()
    {
        var geoSpatialColumnGroupResult = CreateGeoSpatialColumnGroup();
        factoryAction?.Invoke(geoSpatialColumnGroupResult);

        return geoSpatialColumnGroupResult;
    }

    private Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup CreateGeoSpatialColumnGroup()
    {
        var geoSpatialColumnGroupResult = new Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup();

        return geoSpatialColumnGroupResult;
    }

} // End Of Class

public static class InnerDataSetGeoSpatialColumnGroupFactoryExtensions
{
}
