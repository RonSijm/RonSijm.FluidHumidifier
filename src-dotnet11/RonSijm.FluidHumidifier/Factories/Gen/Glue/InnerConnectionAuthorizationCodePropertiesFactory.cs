// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionAuthorizationCodePropertiesFactory(Action<Humidifier.Glue.ConnectionTypes.AuthorizationCodeProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypes.AuthorizationCodeProperties>
{

    protected override Humidifier.Glue.ConnectionTypes.AuthorizationCodeProperties Create()
    {
        var authorizationCodePropertiesResult = CreateAuthorizationCodeProperties();
        factoryAction?.Invoke(authorizationCodePropertiesResult);

        return authorizationCodePropertiesResult;
    }

    private Humidifier.Glue.ConnectionTypes.AuthorizationCodeProperties CreateAuthorizationCodeProperties()
    {
        var authorizationCodePropertiesResult = new Humidifier.Glue.ConnectionTypes.AuthorizationCodeProperties();

        return authorizationCodePropertiesResult;
    }

} // End Of Class

public static class InnerConnectionAuthorizationCodePropertiesFactoryExtensions
{
}
