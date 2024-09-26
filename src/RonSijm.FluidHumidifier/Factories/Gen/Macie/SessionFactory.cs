// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class SessionFactory(string resourceName = null, Action<Humidifier.Macie.Session> factoryAction = null) : ResourceFactory<Humidifier.Macie.Session>(resourceName)
{

    protected override Humidifier.Macie.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.Macie.Session CreateSession()
    {
        var sessionResult = new Humidifier.Macie.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }

} // End Of Class

public static class SessionFactoryExtensions
{
}
