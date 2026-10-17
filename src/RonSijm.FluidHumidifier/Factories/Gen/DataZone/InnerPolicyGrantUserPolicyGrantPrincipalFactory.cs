// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantUserPolicyGrantPrincipalFactory(Action<Humidifier.DataZone.PolicyGrantTypes.UserPolicyGrantPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.UserPolicyGrantPrincipal>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.UserPolicyGrantPrincipal Create()
    {
        var userPolicyGrantPrincipalResult = CreateUserPolicyGrantPrincipal();
        factoryAction?.Invoke(userPolicyGrantPrincipalResult);

        return userPolicyGrantPrincipalResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.UserPolicyGrantPrincipal CreateUserPolicyGrantPrincipal()
    {
        var userPolicyGrantPrincipalResult = new Humidifier.DataZone.PolicyGrantTypes.UserPolicyGrantPrincipal();

        return userPolicyGrantPrincipalResult;
    }

} // End Of Class

public static class InnerPolicyGrantUserPolicyGrantPrincipalFactoryExtensions
{
}
