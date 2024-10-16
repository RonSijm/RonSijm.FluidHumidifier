// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerIdentityProviderDetailsFactory(Action<Humidifier.Transfer.ServerTypes.IdentityProviderDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.IdentityProviderDetails>
{

    protected override Humidifier.Transfer.ServerTypes.IdentityProviderDetails Create()
    {
        var identityProviderDetailsResult = CreateIdentityProviderDetails();
        factoryAction?.Invoke(identityProviderDetailsResult);

        return identityProviderDetailsResult;
    }

    private Humidifier.Transfer.ServerTypes.IdentityProviderDetails CreateIdentityProviderDetails()
    {
        var identityProviderDetailsResult = new Humidifier.Transfer.ServerTypes.IdentityProviderDetails();

        return identityProviderDetailsResult;
    }

} // End Of Class

public static class InnerServerIdentityProviderDetailsFactoryExtensions
{
}
