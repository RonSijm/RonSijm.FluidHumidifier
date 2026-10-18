// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyNetworkAclEntrySetFactory(Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet>
{

    protected override Humidifier.FMS.PolicyTypes.NetworkAclEntrySet Create()
    {
        var networkAclEntrySetResult = CreateNetworkAclEntrySet();
        factoryAction?.Invoke(networkAclEntrySetResult);

        return networkAclEntrySetResult;
    }

    private Humidifier.FMS.PolicyTypes.NetworkAclEntrySet CreateNetworkAclEntrySet()
    {
        var networkAclEntrySetResult = new Humidifier.FMS.PolicyTypes.NetworkAclEntrySet();

        return networkAclEntrySetResult;
    }

} // End Of Class

public static class InnerPolicyNetworkAclEntrySetFactoryExtensions
{
}
