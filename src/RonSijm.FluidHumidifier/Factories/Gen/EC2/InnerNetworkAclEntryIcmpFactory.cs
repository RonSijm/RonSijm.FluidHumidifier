// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkAclEntryIcmpFactory(Action<Humidifier.EC2.NetworkAclEntryTypes.Icmp> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkAclEntryTypes.Icmp>
{

    protected override Humidifier.EC2.NetworkAclEntryTypes.Icmp Create()
    {
        var icmpResult = CreateIcmp();
        factoryAction?.Invoke(icmpResult);

        return icmpResult;
    }

    private Humidifier.EC2.NetworkAclEntryTypes.Icmp CreateIcmp()
    {
        var icmpResult = new Humidifier.EC2.NetworkAclEntryTypes.Icmp();

        return icmpResult;
    }

} // End Of Class

public static class InnerNetworkAclEntryIcmpFactoryExtensions
{
}
