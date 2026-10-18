// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class UserProfileFactory(string resourceName = null, Action<Humidifier.OpsWorks.UserProfile> factoryAction = null) : ResourceFactory<Humidifier.OpsWorks.UserProfile>(resourceName)
{

    protected override Humidifier.OpsWorks.UserProfile Create()
    {
        var userProfileResult = CreateUserProfile();
        factoryAction?.Invoke(userProfileResult);

        return userProfileResult;
    }

    private Humidifier.OpsWorks.UserProfile CreateUserProfile()
    {
        var userProfileResult = new Humidifier.OpsWorks.UserProfile
        {
            GivenName = InputResourceName,
        };

        return userProfileResult;
    }

} // End Of Class

public static class UserProfileFactoryExtensions
{
}
