// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class SiteFactory(string resourceName = null, Action<Humidifier.NetworkManager.Site> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.Site>(resourceName)
{

    internal InnerSiteLocationFactory LocationFactory { get; set; }

    protected override Humidifier.NetworkManager.Site Create()
    {
        var siteResult = CreateSite();
        factoryAction?.Invoke(siteResult);

        return siteResult;
    }

    private Humidifier.NetworkManager.Site CreateSite()
    {
        var siteResult = new Humidifier.NetworkManager.Site
        {
            GivenName = InputResourceName,
        };

        return siteResult;
    }
    public override void CreateChildren(Humidifier.NetworkManager.Site result)
    {
        base.CreateChildren(result);

        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class SiteFactoryExtensions
{
    public static CombinedResult<SiteFactory, InnerSiteLocationFactory> WithLocation(this SiteFactory parentFactory, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerSiteLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<SiteFactory, T1, InnerSiteLocationFactory> WithLocation<T1>(this CombinedResult<SiteFactory, T1> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SiteFactory, InnerSiteLocationFactory> WithLocation<T1>(this CombinedResult<T1, SiteFactory> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SiteFactory, T1, T2, InnerSiteLocationFactory> WithLocation<T1, T2>(this CombinedResult<SiteFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SiteFactory, T2, InnerSiteLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, SiteFactory, T2> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SiteFactory, InnerSiteLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, SiteFactory> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SiteFactory, T1, T2, T3, InnerSiteLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<SiteFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SiteFactory, T2, T3, InnerSiteLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, SiteFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SiteFactory, T3, InnerSiteLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, SiteFactory, T3> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SiteFactory, InnerSiteLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, SiteFactory> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SiteFactory, T1, T2, T3, T4, InnerSiteLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<SiteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SiteFactory, T2, T3, T4, InnerSiteLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, SiteFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SiteFactory, T3, T4, InnerSiteLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, SiteFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SiteFactory, T4, InnerSiteLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SiteFactory, T4> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SiteFactory, InnerSiteLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SiteFactory> combinedResult, Action<Humidifier.NetworkManager.SiteTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
