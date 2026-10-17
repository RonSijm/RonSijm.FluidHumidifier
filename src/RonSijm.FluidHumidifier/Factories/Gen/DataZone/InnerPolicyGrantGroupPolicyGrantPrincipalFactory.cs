// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantGroupPolicyGrantPrincipalFactory(Action<Humidifier.DataZone.PolicyGrantTypes.GroupPolicyGrantPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.GroupPolicyGrantPrincipal>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.GroupPolicyGrantPrincipal Create()
    {
        var groupPolicyGrantPrincipalResult = CreateGroupPolicyGrantPrincipal();
        factoryAction?.Invoke(groupPolicyGrantPrincipalResult);

        return groupPolicyGrantPrincipalResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.GroupPolicyGrantPrincipal CreateGroupPolicyGrantPrincipal()
    {
        var groupPolicyGrantPrincipalResult = new Humidifier.DataZone.PolicyGrantTypes.GroupPolicyGrantPrincipal();

        return groupPolicyGrantPrincipalResult;
    }

} // End Of Class

public static class InnerPolicyGrantGroupPolicyGrantPrincipalFactoryExtensions
{
}
