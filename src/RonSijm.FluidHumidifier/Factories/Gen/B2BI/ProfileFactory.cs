// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class ProfileFactory(string resourceName = null, Action<Humidifier.B2BI.Profile> factoryAction = null) : ResourceFactory<Humidifier.B2BI.Profile>(resourceName)
{

    protected override Humidifier.B2BI.Profile Create()
    {
        var profileResult = CreateProfile();
        factoryAction?.Invoke(profileResult);

        return profileResult;
    }

    private Humidifier.B2BI.Profile CreateProfile()
    {
        var profileResult = new Humidifier.B2BI.Profile
        {
            GivenName = InputResourceName,
        };

        return profileResult;
    }

} // End Of Class

public static class ProfileFactoryExtensions
{
}
