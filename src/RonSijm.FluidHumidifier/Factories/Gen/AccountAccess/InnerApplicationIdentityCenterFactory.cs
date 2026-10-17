// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class InnerApplicationIdentityCenterFactory(Action<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter> factoryAction = null) : SubResourceFactory<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter>
{

    protected override Humidifier.AccountAccess.ApplicationTypes.IdentityCenter Create()
    {
        var identityCenterResult = CreateIdentityCenter();
        factoryAction?.Invoke(identityCenterResult);

        return identityCenterResult;
    }

    private Humidifier.AccountAccess.ApplicationTypes.IdentityCenter CreateIdentityCenter()
    {
        var identityCenterResult = new Humidifier.AccountAccess.ApplicationTypes.IdentityCenter();

        return identityCenterResult;
    }

} // End Of Class

public static class InnerApplicationIdentityCenterFactoryExtensions
{
}
