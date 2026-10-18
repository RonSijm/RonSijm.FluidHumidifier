// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PartnerCentral;

public class ConnectionPreferencesFactory(string resourceName = null, Action<Humidifier.PartnerCentral.ConnectionPreferences> factoryAction = null) : ResourceFactory<Humidifier.PartnerCentral.ConnectionPreferences>(resourceName)
{

    protected override Humidifier.PartnerCentral.ConnectionPreferences Create()
    {
        var connectionPreferencesResult = CreateConnectionPreferences();
        factoryAction?.Invoke(connectionPreferencesResult);

        return connectionPreferencesResult;
    }

    private Humidifier.PartnerCentral.ConnectionPreferences CreateConnectionPreferences()
    {
        var connectionPreferencesResult = new Humidifier.PartnerCentral.ConnectionPreferences
        {
            GivenName = InputResourceName,
        };

        return connectionPreferencesResult;
    }

} // End Of Class

public static class ConnectionPreferencesFactoryExtensions
{
}
