// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class UserFactory(string resourceName = null, Action<Humidifier.AppStream.User> factoryAction = null) : ResourceFactory<Humidifier.AppStream.User>(resourceName)
{

    protected override Humidifier.AppStream.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.AppStream.User CreateUser()
    {
        var userResult = new Humidifier.AppStream.User
        {
            GivenName = InputResourceName,
        };

        return userResult;
    }

} // End Of Class

public static class UserFactoryExtensions
{
}
