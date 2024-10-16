// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolGroupFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolGroup> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolGroup>(resourceName)
{

    protected override Humidifier.Cognito.UserPoolGroup Create()
    {
        var userPoolGroupResult = CreateUserPoolGroup();
        factoryAction?.Invoke(userPoolGroupResult);

        return userPoolGroupResult;
    }

    private Humidifier.Cognito.UserPoolGroup CreateUserPoolGroup()
    {
        var userPoolGroupResult = new Humidifier.Cognito.UserPoolGroup
        {
            GivenName = InputResourceName,
        };

        return userPoolGroupResult;
    }

} // End Of Class

public static class UserPoolGroupFactoryExtensions
{
}
