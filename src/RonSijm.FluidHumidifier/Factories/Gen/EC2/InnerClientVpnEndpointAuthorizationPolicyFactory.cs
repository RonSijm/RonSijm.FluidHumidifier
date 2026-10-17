// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointAuthorizationPolicyFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy Create()
    {
        var authorizationPolicyResult = CreateAuthorizationPolicy();
        factoryAction?.Invoke(authorizationPolicyResult);

        return authorizationPolicyResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy CreateAuthorizationPolicy()
    {
        var authorizationPolicyResult = new Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy();

        return authorizationPolicyResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointAuthorizationPolicyFactoryExtensions
{
}
