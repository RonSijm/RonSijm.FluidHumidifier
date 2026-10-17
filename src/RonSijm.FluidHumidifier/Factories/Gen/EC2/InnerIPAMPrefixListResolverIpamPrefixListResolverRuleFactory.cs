// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory(Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule>
{

    protected override Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule Create()
    {
        var ipamPrefixListResolverRuleResult = CreateIpamPrefixListResolverRule();
        factoryAction?.Invoke(ipamPrefixListResolverRuleResult);

        return ipamPrefixListResolverRuleResult;
    }

    private Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule CreateIpamPrefixListResolverRule()
    {
        var ipamPrefixListResolverRuleResult = new Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule();

        return ipamPrefixListResolverRuleResult;
    }

} // End Of Class

public static class InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactoryExtensions
{
}
