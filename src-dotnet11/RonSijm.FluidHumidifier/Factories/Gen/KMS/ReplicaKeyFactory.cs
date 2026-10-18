// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KMS;

public class ReplicaKeyFactory(string resourceName = null, Action<Humidifier.KMS.ReplicaKey> factoryAction = null) : ResourceFactory<Humidifier.KMS.ReplicaKey>(resourceName)
{

    protected override Humidifier.KMS.ReplicaKey Create()
    {
        var replicaKeyResult = CreateReplicaKey();
        factoryAction?.Invoke(replicaKeyResult);

        return replicaKeyResult;
    }

    private Humidifier.KMS.ReplicaKey CreateReplicaKey()
    {
        var replicaKeyResult = new Humidifier.KMS.ReplicaKey
        {
            GivenName = InputResourceName,
        };

        return replicaKeyResult;
    }

} // End Of Class

public static class ReplicaKeyFactoryExtensions
{
}
