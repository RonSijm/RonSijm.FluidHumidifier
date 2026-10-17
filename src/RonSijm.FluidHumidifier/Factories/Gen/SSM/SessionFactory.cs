// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class SessionFactory(string resourceName = null, Action<Humidifier.SSM.Session> factoryAction = null) : ResourceFactory<Humidifier.SSM.Session>(resourceName)
{

    protected override Humidifier.SSM.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.SSM.Session CreateSession()
    {
        var sessionResult = new Humidifier.SSM.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }

} // End Of Class

public static class SessionFactoryExtensions
{
}
