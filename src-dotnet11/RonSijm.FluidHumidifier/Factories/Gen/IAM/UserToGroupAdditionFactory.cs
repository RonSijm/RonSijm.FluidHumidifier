// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class UserToGroupAdditionFactory(string resourceName = null, Action<Humidifier.IAM.UserToGroupAddition> factoryAction = null) : ResourceFactory<Humidifier.IAM.UserToGroupAddition>(resourceName)
{

    protected override Humidifier.IAM.UserToGroupAddition Create()
    {
        var userToGroupAdditionResult = CreateUserToGroupAddition();
        factoryAction?.Invoke(userToGroupAdditionResult);

        return userToGroupAdditionResult;
    }

    private Humidifier.IAM.UserToGroupAddition CreateUserToGroupAddition()
    {
        var userToGroupAdditionResult = new Humidifier.IAM.UserToGroupAddition
        {
            GivenName = InputResourceName,
        };

        return userToGroupAdditionResult;
    }

} // End Of Class

public static class UserToGroupAdditionFactoryExtensions
{
}
