// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class FirewallFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.Firewall> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.Firewall>(resourceName)
{

    internal List<InnerFirewallSubnetMappingFactory> SubnetMappingsFactories { get; set; } = [];

    protected override Humidifier.NetworkFirewall.Firewall Create()
    {
        var firewallResult = CreateFirewall();
        factoryAction?.Invoke(firewallResult);

        return firewallResult;
    }

    private Humidifier.NetworkFirewall.Firewall CreateFirewall()
    {
        var firewallResult = new Humidifier.NetworkFirewall.Firewall
        {
            GivenName = InputResourceName,
        };

        return firewallResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.Firewall result)
    {
        base.CreateChildren(result);

        result.SubnetMappings = SubnetMappingsFactories.Any() ? SubnetMappingsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FirewallFactoryExtensions
{
    public static CombinedResult<FirewallFactory, InnerFirewallSubnetMappingFactory> WithSubnetMappings(this FirewallFactory parentFactory, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null)
    {
        var factory = new InnerFirewallSubnetMappingFactory(subFactoryAction);
        parentFactory.SubnetMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FirewallFactory, T1, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1>(this CombinedResult<FirewallFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallFactory, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1>(this CombinedResult<T1, FirewallFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FirewallFactory, T1, T2, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2>(this CombinedResult<FirewallFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallFactory, T2, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2>(this CombinedResult<T1, FirewallFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallFactory, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2>(this CombinedResult<T1, T2, FirewallFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FirewallFactory, T1, T2, T3, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<FirewallFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallFactory, T2, T3, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<T1, FirewallFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallFactory, T3, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<T1, T2, FirewallFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FirewallFactory, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, FirewallFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FirewallFactory, T1, T2, T3, T4, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<FirewallFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallFactory, T2, T3, T4, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, FirewallFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallFactory, T3, T4, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, FirewallFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FirewallFactory, T4, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FirewallFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FirewallFactory, InnerFirewallSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FirewallFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T5, subFactoryAction));
}
