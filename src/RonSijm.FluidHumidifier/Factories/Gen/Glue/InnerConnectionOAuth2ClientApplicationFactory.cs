// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionOAuth2ClientApplicationFactory(Action<Humidifier.Glue.ConnectionTypes.OAuth2ClientApplication> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypes.OAuth2ClientApplication>
{

    protected override Humidifier.Glue.ConnectionTypes.OAuth2ClientApplication Create()
    {
        var oAuth2ClientApplicationResult = CreateOAuth2ClientApplication();
        factoryAction?.Invoke(oAuth2ClientApplicationResult);

        return oAuth2ClientApplicationResult;
    }

    private Humidifier.Glue.ConnectionTypes.OAuth2ClientApplication CreateOAuth2ClientApplication()
    {
        var oAuth2ClientApplicationResult = new Humidifier.Glue.ConnectionTypes.OAuth2ClientApplication();

        return oAuth2ClientApplicationResult;
    }

} // End Of Class

public static class InnerConnectionOAuth2ClientApplicationFactoryExtensions
{
}
