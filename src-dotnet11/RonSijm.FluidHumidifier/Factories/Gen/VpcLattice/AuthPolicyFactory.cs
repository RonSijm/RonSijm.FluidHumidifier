// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class AuthPolicyFactory(string resourceName = null, Action<Humidifier.VpcLattice.AuthPolicy> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.AuthPolicy>(resourceName)
{

    protected override Humidifier.VpcLattice.AuthPolicy Create()
    {
        var authPolicyResult = CreateAuthPolicy();
        factoryAction?.Invoke(authPolicyResult);

        return authPolicyResult;
    }

    private Humidifier.VpcLattice.AuthPolicy CreateAuthPolicy()
    {
        var authPolicyResult = new Humidifier.VpcLattice.AuthPolicy
        {
            GivenName = InputResourceName,
        };

        return authPolicyResult;
    }

} // End Of Class

public static class AuthPolicyFactoryExtensions
{
}
