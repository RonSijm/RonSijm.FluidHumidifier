// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerUserAuthenticationModeFactory(Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.UserTypes.AuthenticationMode>
{

    protected override Humidifier.ElastiCache.UserTypes.AuthenticationMode Create()
    {
        var authenticationModeResult = CreateAuthenticationMode();
        factoryAction?.Invoke(authenticationModeResult);

        return authenticationModeResult;
    }

    private Humidifier.ElastiCache.UserTypes.AuthenticationMode CreateAuthenticationMode()
    {
        var authenticationModeResult = new Humidifier.ElastiCache.UserTypes.AuthenticationMode();

        return authenticationModeResult;
    }

} // End Of Class

public static class InnerUserAuthenticationModeFactoryExtensions
{
}
