// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashDvbSettingsFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings>
{

    internal InnerOriginEndpointDashDvbFontDownloadFactory FontDownloadFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings Create()
    {
        var dashDvbSettingsResult = CreateDashDvbSettings();
        factoryAction?.Invoke(dashDvbSettingsResult);

        return dashDvbSettingsResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings CreateDashDvbSettings()
    {
        var dashDvbSettingsResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings();

        return dashDvbSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings result)
    {
        base.CreateChildren(result);

        result.FontDownload ??= FontDownloadFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointDashDvbSettingsFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload(this InnerOriginEndpointDashDvbSettingsFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null)
    {
        parentFactory.FontDownloadFactory = new InnerOriginEndpointDashDvbFontDownloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FontDownloadFactory);
    }

    public static CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1>(this CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontDownload(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1>(this CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontDownload(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, T2, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2>(this CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, T2, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2>(this CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointDashDvbSettingsFactory, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointDashDvbSettingsFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, T2, T3, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3>(this CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, T2, T3, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointDashDvbSettingsFactory, T3, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointDashDvbSettingsFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashDvbSettingsFactory, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashDvbSettingsFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, T2, T3, T4, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointDashDvbSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, T2, T3, T4, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointDashDvbSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointDashDvbSettingsFactory, T3, T4, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointDashDvbSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashDvbSettingsFactory, T4, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashDvbSettingsFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashDvbSettingsFactory, InnerOriginEndpointDashDvbFontDownloadFactory> WithFontDownload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashDvbSettingsFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontDownload(combinedResult.T5, subFactoryAction).T2);
}
