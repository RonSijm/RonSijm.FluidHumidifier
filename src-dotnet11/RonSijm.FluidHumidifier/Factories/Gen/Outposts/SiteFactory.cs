// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Outposts;

public class SiteFactory(string resourceName = null, Action<Humidifier.Outposts.Site> factoryAction = null) : ResourceFactory<Humidifier.Outposts.Site>(resourceName)
{

    internal InnerSiteRackPhysicalPropertiesFactory RackPhysicalPropertiesFactory { get; set; }

    internal InnerSiteAddressFactory ShippingAddressFactory { get; set; }

    internal InnerSiteAddressFactory OperatingAddressFactory { get; set; }

    protected override Humidifier.Outposts.Site Create()
    {
        var siteResult = CreateSite();
        factoryAction?.Invoke(siteResult);

        return siteResult;
    }

    private Humidifier.Outposts.Site CreateSite()
    {
        var siteResult = new Humidifier.Outposts.Site
        {
            GivenName = InputResourceName,
        };

        return siteResult;
    }
    public override void CreateChildren(Humidifier.Outposts.Site result)
    {
        base.CreateChildren(result);

        result.RackPhysicalProperties ??= RackPhysicalPropertiesFactory?.Build();
        result.ShippingAddress ??= ShippingAddressFactory?.Build();
        result.OperatingAddress ??= OperatingAddressFactory?.Build();
    }

} // End Of Class

public static class SiteFactoryExtensions
{
    public static CombinedResult<SiteFactory, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties(this SiteFactory parentFactory, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null)
    {
        parentFactory.RackPhysicalPropertiesFactory = new InnerSiteRackPhysicalPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RackPhysicalPropertiesFactory);
    }

    public static CombinedResult<SiteFactory, InnerSiteAddressFactory> WithShippingAddress(this SiteFactory parentFactory, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null)
    {
        parentFactory.ShippingAddressFactory = new InnerSiteAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ShippingAddressFactory);
    }

    public static CombinedResult<SiteFactory, InnerSiteAddressFactory> WithOperatingAddress(this SiteFactory parentFactory, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null)
    {
        parentFactory.OperatingAddressFactory = new InnerSiteAddressFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OperatingAddressFactory);
    }

    public static CombinedResult<SiteFactory, T1, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1>(this CombinedResult<SiteFactory, T1> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1>(this CombinedResult<T1, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2>(this CombinedResult<SiteFactory, T1, T2> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2>(this CombinedResult<T1, SiteFactory, T2> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2>(this CombinedResult<T1, T2, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, T3, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3>(this CombinedResult<SiteFactory, T1, T2, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, T3, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3>(this CombinedResult<T1, SiteFactory, T2, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, T3, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3>(this CombinedResult<T1, T2, SiteFactory, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SiteFactory, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, T3, T4, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3, T4>(this CombinedResult<SiteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, T3, T4, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3, T4>(this CombinedResult<T1, SiteFactory, T2, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, T3, T4, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, SiteFactory, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SiteFactory, T4, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SiteFactory, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SiteFactory, InnerSiteRackPhysicalPropertiesFactory> WithRackPhysicalProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRackPhysicalProperties(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, InnerSiteAddressFactory> WithShippingAddress<T1>(this CombinedResult<SiteFactory, T1> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, WithShippingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, InnerSiteAddressFactory> WithShippingAddress<T1>(this CombinedResult<T1, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, WithShippingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, InnerSiteAddressFactory> WithShippingAddress<T1, T2>(this CombinedResult<SiteFactory, T1, T2> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, InnerSiteAddressFactory> WithShippingAddress<T1, T2>(this CombinedResult<T1, SiteFactory, T2> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, InnerSiteAddressFactory> WithShippingAddress<T1, T2>(this CombinedResult<T1, T2, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, T3, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3>(this CombinedResult<SiteFactory, T1, T2, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, T3, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3>(this CombinedResult<T1, SiteFactory, T2, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, T3, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3>(this CombinedResult<T1, T2, SiteFactory, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SiteFactory, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, T3, T4, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3, T4>(this CombinedResult<SiteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, T3, T4, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3, T4>(this CombinedResult<T1, SiteFactory, T2, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, T3, T4, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, SiteFactory, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SiteFactory, T4, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SiteFactory, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SiteFactory, InnerSiteAddressFactory> WithShippingAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShippingAddress(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, InnerSiteAddressFactory> WithOperatingAddress<T1>(this CombinedResult<SiteFactory, T1> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, InnerSiteAddressFactory> WithOperatingAddress<T1>(this CombinedResult<T1, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, InnerSiteAddressFactory> WithOperatingAddress<T1, T2>(this CombinedResult<SiteFactory, T1, T2> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, InnerSiteAddressFactory> WithOperatingAddress<T1, T2>(this CombinedResult<T1, SiteFactory, T2> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, InnerSiteAddressFactory> WithOperatingAddress<T1, T2>(this CombinedResult<T1, T2, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, T3, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3>(this CombinedResult<SiteFactory, T1, T2, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, T3, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3>(this CombinedResult<T1, SiteFactory, T2, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, T3, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3>(this CombinedResult<T1, T2, SiteFactory, T3> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SiteFactory, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3>(this CombinedResult<T1, T2, T3, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SiteFactory, T1, T2, T3, T4, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3, T4>(this CombinedResult<SiteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SiteFactory, T2, T3, T4, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3, T4>(this CombinedResult<T1, SiteFactory, T2, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SiteFactory, T3, T4, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, SiteFactory, T3, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SiteFactory, T4, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SiteFactory, T4> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SiteFactory, InnerSiteAddressFactory> WithOperatingAddress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SiteFactory> combinedResult, Action<Humidifier.Outposts.SiteTypes.Address> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingAddress(combinedResult.T5, subFactoryAction).T2);
}
