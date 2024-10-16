// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMResourceDiscoveryFactory(string resourceName = null, Action<Humidifier.EC2.IPAMResourceDiscovery> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMResourceDiscovery>(resourceName)
{

    internal List<InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> OperatingRegionsFactories { get; set; } = [];

    protected override Humidifier.EC2.IPAMResourceDiscovery Create()
    {
        var iPAMResourceDiscoveryResult = CreateIPAMResourceDiscovery();
        factoryAction?.Invoke(iPAMResourceDiscoveryResult);

        return iPAMResourceDiscoveryResult;
    }

    private Humidifier.EC2.IPAMResourceDiscovery CreateIPAMResourceDiscovery()
    {
        var iPAMResourceDiscoveryResult = new Humidifier.EC2.IPAMResourceDiscovery
        {
            GivenName = InputResourceName,
        };

        return iPAMResourceDiscoveryResult;
    }
    public override void CreateChildren(Humidifier.EC2.IPAMResourceDiscovery result)
    {
        base.CreateChildren(result);

        result.OperatingRegions = OperatingRegionsFactories.Any() ? OperatingRegionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IPAMResourceDiscoveryFactoryExtensions
{
    public static CombinedResult<IPAMResourceDiscoveryFactory, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions(this IPAMResourceDiscoveryFactory parentFactory, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null)
    {
        var factory = new InnerIPAMResourceDiscoveryIpamOperatingRegionFactory(subFactoryAction);
        parentFactory.OperatingRegionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPAMResourceDiscoveryFactory, T1, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1>(this CombinedResult<IPAMResourceDiscoveryFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMResourceDiscoveryFactory, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1>(this CombinedResult<T1, IPAMResourceDiscoveryFactory> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IPAMResourceDiscoveryFactory, T1, T2, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2>(this CombinedResult<IPAMResourceDiscoveryFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMResourceDiscoveryFactory, T2, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2>(this CombinedResult<T1, IPAMResourceDiscoveryFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMResourceDiscoveryFactory, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2>(this CombinedResult<T1, T2, IPAMResourceDiscoveryFactory> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IPAMResourceDiscoveryFactory, T1, T2, T3, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<IPAMResourceDiscoveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMResourceDiscoveryFactory, T2, T3, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<T1, IPAMResourceDiscoveryFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMResourceDiscoveryFactory, T3, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<T1, T2, IPAMResourceDiscoveryFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPAMResourceDiscoveryFactory, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMResourceDiscoveryFactory> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IPAMResourceDiscoveryFactory, T1, T2, T3, T4, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<IPAMResourceDiscoveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPAMResourceDiscoveryFactory, T2, T3, T4, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, IPAMResourceDiscoveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPAMResourceDiscoveryFactory, T3, T4, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMResourceDiscoveryFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPAMResourceDiscoveryFactory, T4, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMResourceDiscoveryFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IPAMResourceDiscoveryFactory, InnerIPAMResourceDiscoveryIpamOperatingRegionFactory> WithOperatingRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMResourceDiscoveryFactory> combinedResult, Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatingRegions(combinedResult.T5, subFactoryAction));
}
