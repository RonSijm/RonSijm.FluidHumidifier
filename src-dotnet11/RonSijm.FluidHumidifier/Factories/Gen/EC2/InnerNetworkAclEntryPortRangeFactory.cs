// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkAclEntryPortRangeFactory(Action<Humidifier.EC2.NetworkAclEntryTypes.PortRange> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkAclEntryTypes.PortRange>
{

    protected override Humidifier.EC2.NetworkAclEntryTypes.PortRange Create()
    {
        var portRangeResult = CreatePortRange();
        factoryAction?.Invoke(portRangeResult);

        return portRangeResult;
    }

    private Humidifier.EC2.NetworkAclEntryTypes.PortRange CreatePortRange()
    {
        var portRangeResult = new Humidifier.EC2.NetworkAclEntryTypes.PortRange();

        return portRangeResult;
    }

} // End Of Class

public static class InnerNetworkAclEntryPortRangeFactoryExtensions
{
}
