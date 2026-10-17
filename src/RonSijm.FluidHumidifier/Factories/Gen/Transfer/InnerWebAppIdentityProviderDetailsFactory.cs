// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWebAppIdentityProviderDetailsFactory(Action<Humidifier.Transfer.WebAppTypes.IdentityProviderDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WebAppTypes.IdentityProviderDetails>
{

    protected override Humidifier.Transfer.WebAppTypes.IdentityProviderDetails Create()
    {
        var identityProviderDetailsResult = CreateIdentityProviderDetails();
        factoryAction?.Invoke(identityProviderDetailsResult);

        return identityProviderDetailsResult;
    }

    private Humidifier.Transfer.WebAppTypes.IdentityProviderDetails CreateIdentityProviderDetails()
    {
        var identityProviderDetailsResult = new Humidifier.Transfer.WebAppTypes.IdentityProviderDetails();

        return identityProviderDetailsResult;
    }

} // End Of Class

public static class InnerWebAppIdentityProviderDetailsFactoryExtensions
{
}
