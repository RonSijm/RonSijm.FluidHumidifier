// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Profiles;

public class ProfileFactory(string resourceName = null, Action<Humidifier.Route53Profiles.Profile> factoryAction = null) : ResourceFactory<Humidifier.Route53Profiles.Profile>(resourceName)
{

    protected override Humidifier.Route53Profiles.Profile Create()
    {
        var profileResult = CreateProfile();
        factoryAction?.Invoke(profileResult);

        return profileResult;
    }

    private Humidifier.Route53Profiles.Profile CreateProfile()
    {
        var profileResult = new Humidifier.Route53Profiles.Profile
        {
            GivenName = InputResourceName,
        };

        return profileResult;
    }

} // End Of Class

public static class ProfileFactoryExtensions
{
}
