// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMFactory(string resourceName = null, Action<Humidifier.EC2.IPAM> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAM>(resourceName)
{

    internal List<InnerIPAMIpamOrganizationalUnitExclusionFactory> DefaultResourceDiscoveryOrganizationalUnitExclusionsFactories { get; set; } = [];

    internal List<InnerIPAMIpamOperatingRegionFactory> OperatingRegionsFactories { get; set; } = [];

    protected override Humidifier.EC2.IPAM Create()
    {
        var iPAMResult = CreateIPAM();
        factoryAction?.Invoke(iPAMResult);

        return iPAMResult;
    }

    private Humidifier.EC2.IPAM CreateIPAM()
    {
        var iPAMResult = new Humidifier.EC2.IPAM
        {
            GivenName = InputResourceName,
        };

        return iPAMResult;
    }
    public override void CreateChildren(Humidifier.EC2.IPAM result)
    {
        base.CreateChildren(result);

        result.DefaultResourceDiscoveryOrganizationalUnitExclusions = DefaultResourceDiscoveryOrganizationalUnitExclusionsFactories.Any() ? DefaultResourceDiscoveryOrganizationalUnitExclusionsFactories.Select(x => x.Build()).ToList() : null;
        result.OperatingRegions = OperatingRegionsFactories.Any() ? OperatingRegionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IPAMFactoryExtensions
{
    public static CombinedResult<IPAMFactory, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions(this IPAMFactory parentFactory, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null)
    {
        var factory = new InnerIPAMIpamOrganizationalUnitExclusionFactory(subFactoryAction);
        parentFactory.DefaultResourceDiscoveryOrganizationalUnitExclusionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPAMFactory, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions(this IPAMFactory parentFactory, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null)
    {
        var factory = new InnerIPAMIpamOperatingRegionFactory(subFactoryAction);
        parentFactory.OperatingRegionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPAMFactory, T1, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1>(this CombinedResult<IPAMFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1>(this CombinedResult<T1, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, T2, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2>(this CombinedResult<IPAMFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, T2, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2>(this CombinedResult<T1, IPAMFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMFactory, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2>(this CombinedResult<T1, T2, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, T2, T3, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3>(this CombinedResult<IPAMFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, T2, T3, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3>(this CombinedResult<T1, IPAMFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMFactory, T3, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3>(this CombinedResult<T1, T2, IPAMFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMFactory, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, T2, T3, T4, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3, T4>(this CombinedResult<IPAMFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, T2, T3, T4, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3, T4>(this CombinedResult<T1, IPAMFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMFactory, T3, T4, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMFactory, T4, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IPAMFactory, InnerIPAMIpamOrganizationalUnitExclusionFactory> WithDefaultResourceDiscoveryOrganizationalUnitExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceDiscoveryOrganizationalUnitExclusions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1>(this CombinedResult<IPAMFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1>(this CombinedResult<T1, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, T2, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2>(this CombinedResult<IPAMFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, T2, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2>(this CombinedResult<T1, IPAMFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMFactory, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2>(this CombinedResult<T1, T2, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, T2, T3, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<IPAMFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, T2, T3, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<T1, IPAMFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMFactory, T3, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<T1, T2, IPAMFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMFactory, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IPAMFactory, T1, T2, T3, T4, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<IPAMFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMFactory, T2, T3, T4, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, IPAMFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMFactory, T3, T4, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMFactory, T4, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IPAMFactory, InnerIPAMIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMFactory> combinedResult, Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T5, subFactoryAction).T2);
}
