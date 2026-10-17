// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashDvbFontDownloadFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload Create()
    {
        var dashDvbFontDownloadResult = CreateDashDvbFontDownload();
        factoryAction?.Invoke(dashDvbFontDownloadResult);

        return dashDvbFontDownloadResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload CreateDashDvbFontDownload()
    {
        var dashDvbFontDownloadResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload();

        return dashDvbFontDownloadResult;
    }

} // End Of Class

public static class InnerOriginEndpointDashDvbFontDownloadFactoryExtensions
{
}
