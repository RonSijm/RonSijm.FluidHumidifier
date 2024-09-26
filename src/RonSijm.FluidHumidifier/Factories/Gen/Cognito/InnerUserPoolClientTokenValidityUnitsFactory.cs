// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolClientTokenValidityUnitsFactory(Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits>
{

    protected override Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits Create()
    {
        var tokenValidityUnitsResult = CreateTokenValidityUnits();
        factoryAction?.Invoke(tokenValidityUnitsResult);

        return tokenValidityUnitsResult;
    }

    private Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits CreateTokenValidityUnits()
    {
        var tokenValidityUnitsResult = new Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits();

        return tokenValidityUnitsResult;
    }

} // End Of Class

public static class InnerUserPoolClientTokenValidityUnitsFactoryExtensions
{
}
