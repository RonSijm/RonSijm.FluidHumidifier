// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class ProfileFactory(string resourceName = null, Action<Humidifier.Transfer.Profile> factoryAction = null) : ResourceFactory<Humidifier.Transfer.Profile>(resourceName)
{

    protected override Humidifier.Transfer.Profile Create()
    {
        var profileResult = CreateProfile();
        factoryAction?.Invoke(profileResult);

        return profileResult;
    }

    private Humidifier.Transfer.Profile CreateProfile()
    {
        var profileResult = new Humidifier.Transfer.Profile
        {
            GivenName = InputResourceName,
        };

        return profileResult;
    }

} // End Of Class

public static class ProfileFactoryExtensions
{
}
