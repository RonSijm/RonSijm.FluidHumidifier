// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorAuthorizationCodeGrantDetailsFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails Create()
    {
        var authorizationCodeGrantDetailsResult = CreateAuthorizationCodeGrantDetails();
        factoryAction?.Invoke(authorizationCodeGrantDetailsResult);

        return authorizationCodeGrantDetailsResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails CreateAuthorizationCodeGrantDetails()
    {
        var authorizationCodeGrantDetailsResult = new Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails();

        return authorizationCodeGrantDetailsResult;
    }

} // End Of Class

public static class InnerActionConnectorAuthorizationCodeGrantDetailsFactoryExtensions
{
}
