// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolReplicaFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolReplica> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolReplica>(resourceName)
{

    protected override Humidifier.Cognito.UserPoolReplica Create()
    {
        var userPoolReplicaResult = CreateUserPoolReplica();
        factoryAction?.Invoke(userPoolReplicaResult);

        return userPoolReplicaResult;
    }

    private Humidifier.Cognito.UserPoolReplica CreateUserPoolReplica()
    {
        var userPoolReplicaResult = new Humidifier.Cognito.UserPoolReplica
        {
            GivenName = InputResourceName,
        };

        return userPoolReplicaResult;
    }

} // End Of Class

public static class UserPoolReplicaFactoryExtensions
{
}
