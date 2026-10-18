// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class UserProfileFactory(string resourceName = null, Action<Humidifier.DataZone.UserProfile> factoryAction = null) : ResourceFactory<Humidifier.DataZone.UserProfile>(resourceName)
{

    protected override Humidifier.DataZone.UserProfile Create()
    {
        var userProfileResult = CreateUserProfile();
        factoryAction?.Invoke(userProfileResult);

        return userProfileResult;
    }

    private Humidifier.DataZone.UserProfile CreateUserProfile()
    {
        var userProfileResult = new Humidifier.DataZone.UserProfile
        {
            GivenName = InputResourceName,
        };

        return userProfileResult;
    }

} // End Of Class

public static class UserProfileFactoryExtensions
{
}
