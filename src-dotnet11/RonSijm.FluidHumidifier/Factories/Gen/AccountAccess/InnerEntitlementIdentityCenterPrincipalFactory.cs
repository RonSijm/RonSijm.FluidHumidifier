// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class InnerEntitlementIdentityCenterPrincipalFactory(Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal>
{

    protected override Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal Create()
    {
        var identityCenterPrincipalResult = CreateIdentityCenterPrincipal();
        factoryAction?.Invoke(identityCenterPrincipalResult);

        return identityCenterPrincipalResult;
    }

    private Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal CreateIdentityCenterPrincipal()
    {
        var identityCenterPrincipalResult = new Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal();

        return identityCenterPrincipalResult;
    }

} // End Of Class

public static class InnerEntitlementIdentityCenterPrincipalFactoryExtensions
{
}
