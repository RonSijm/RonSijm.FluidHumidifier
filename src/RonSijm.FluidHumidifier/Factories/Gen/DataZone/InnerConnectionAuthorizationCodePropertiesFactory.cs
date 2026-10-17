// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionAuthorizationCodePropertiesFactory(Action<Humidifier.DataZone.ConnectionTypes.AuthorizationCodeProperties> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.AuthorizationCodeProperties>
{

    protected override Humidifier.DataZone.ConnectionTypes.AuthorizationCodeProperties Create()
    {
        var authorizationCodePropertiesResult = CreateAuthorizationCodeProperties();
        factoryAction?.Invoke(authorizationCodePropertiesResult);

        return authorizationCodePropertiesResult;
    }

    private Humidifier.DataZone.ConnectionTypes.AuthorizationCodeProperties CreateAuthorizationCodeProperties()
    {
        var authorizationCodePropertiesResult = new Humidifier.DataZone.ConnectionTypes.AuthorizationCodeProperties();

        return authorizationCodePropertiesResult;
    }

} // End Of Class

public static class InnerConnectionAuthorizationCodePropertiesFactoryExtensions
{
}
