// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class InnerSecretReplicaRegionFactory(Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> factoryAction = null) : SubResourceFactory<Humidifier.SecretsManager.SecretTypes.ReplicaRegion>
{

    protected override Humidifier.SecretsManager.SecretTypes.ReplicaRegion Create()
    {
        var replicaRegionResult = CreateReplicaRegion();
        factoryAction?.Invoke(replicaRegionResult);

        return replicaRegionResult;
    }

    private Humidifier.SecretsManager.SecretTypes.ReplicaRegion CreateReplicaRegion()
    {
        var replicaRegionResult = new Humidifier.SecretsManager.SecretTypes.ReplicaRegion();

        return replicaRegionResult;
    }

} // End Of Class

public static class InnerSecretReplicaRegionFactoryExtensions
{
}
