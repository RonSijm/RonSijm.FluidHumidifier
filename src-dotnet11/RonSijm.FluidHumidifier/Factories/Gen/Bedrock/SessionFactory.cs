// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class SessionFactory(string resourceName = null, Action<Humidifier.Bedrock.Session> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.Session>(resourceName)
{

    protected override Humidifier.Bedrock.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.Bedrock.Session CreateSession()
    {
        var sessionResult = new Humidifier.Bedrock.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }

} // End Of Class

public static class SessionFactoryExtensions
{
}
