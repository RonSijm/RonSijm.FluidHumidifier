// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceManifestFileLocationFactory(Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation>
{

    protected override Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation Create()
    {
        var manifestFileLocationResult = CreateManifestFileLocation();
        factoryAction?.Invoke(manifestFileLocationResult);

        return manifestFileLocationResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation CreateManifestFileLocation()
    {
        var manifestFileLocationResult = new Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation();

        return manifestFileLocationResult;
    }

} // End Of Class

public static class InnerDataSourceManifestFileLocationFactoryExtensions
{
}
