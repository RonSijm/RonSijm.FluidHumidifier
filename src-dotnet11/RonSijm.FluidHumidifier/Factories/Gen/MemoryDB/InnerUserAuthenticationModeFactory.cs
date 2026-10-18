// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class InnerUserAuthenticationModeFactory(Action<Humidifier.MemoryDB.UserTypes.AuthenticationMode> factoryAction = null) : SubResourceFactory<Humidifier.MemoryDB.UserTypes.AuthenticationMode>
{

    protected override Humidifier.MemoryDB.UserTypes.AuthenticationMode Create()
    {
        var authenticationModeResult = CreateAuthenticationMode();
        factoryAction?.Invoke(authenticationModeResult);

        return authenticationModeResult;
    }

    private Humidifier.MemoryDB.UserTypes.AuthenticationMode CreateAuthenticationMode()
    {
        var authenticationModeResult = new Humidifier.MemoryDB.UserTypes.AuthenticationMode();

        return authenticationModeResult;
    }

} // End Of Class

public static class InnerUserAuthenticationModeFactoryExtensions
{
}
