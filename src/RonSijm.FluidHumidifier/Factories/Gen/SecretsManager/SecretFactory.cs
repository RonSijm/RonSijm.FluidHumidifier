// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class SecretFactory(string resourceName = null, Action<Humidifier.SecretsManager.Secret> factoryAction = null) : ResourceFactory<Humidifier.SecretsManager.Secret>(resourceName)
{

    internal List<InnerSecretReplicaRegionFactory> ReplicaRegionsFactories { get; set; } = [];

    internal InnerSecretGenerateSecretStringFactory GenerateSecretStringFactory { get; set; }

    protected override Humidifier.SecretsManager.Secret Create()
    {
        var secretResult = CreateSecret();
        factoryAction?.Invoke(secretResult);

        return secretResult;
    }

    private Humidifier.SecretsManager.Secret CreateSecret()
    {
        var secretResult = new Humidifier.SecretsManager.Secret
        {
            GivenName = InputResourceName,
        };

        return secretResult;
    }
    public override void CreateChildren(Humidifier.SecretsManager.Secret result)
    {
        base.CreateChildren(result);

        result.ReplicaRegions = ReplicaRegionsFactories.Any() ? ReplicaRegionsFactories.Select(x => x.Build()).ToList() : null;
        result.GenerateSecretString ??= GenerateSecretStringFactory?.Build();
    }

} // End Of Class

public static class SecretFactoryExtensions
{
    public static CombinedResult<SecretFactory, InnerSecretReplicaRegionFactory> WithReplicaRegions(this SecretFactory parentFactory, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null)
    {
        var factory = new InnerSecretReplicaRegionFactory(subFactoryAction);
        parentFactory.ReplicaRegionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SecretFactory, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString(this SecretFactory parentFactory, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null)
    {
        parentFactory.GenerateSecretStringFactory = new InnerSecretGenerateSecretStringFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GenerateSecretStringFactory);
    }

    public static CombinedResult<SecretFactory, T1, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1>(this CombinedResult<SecretFactory, T1> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicaRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1>(this CombinedResult<T1, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicaRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, T2, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2>(this CombinedResult<SecretFactory, T1, T2> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, T2, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2>(this CombinedResult<T1, SecretFactory, T2> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecretFactory, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2>(this CombinedResult<T1, T2, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, T2, T3, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3>(this CombinedResult<SecretFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, T2, T3, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3>(this CombinedResult<T1, SecretFactory, T2, T3> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecretFactory, T3, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3>(this CombinedResult<T1, T2, SecretFactory, T3> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecretFactory, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, T2, T3, T4, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3, T4>(this CombinedResult<SecretFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, T2, T3, T4, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3, T4>(this CombinedResult<T1, SecretFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecretFactory, T3, T4, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecretFactory, T3, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecretFactory, T4, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecretFactory, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecretFactory, InnerSecretReplicaRegionFactory> WithReplicaRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.ReplicaRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicaRegions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1>(this CombinedResult<SecretFactory, T1> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1>(this CombinedResult<T1, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, T2, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2>(this CombinedResult<SecretFactory, T1, T2> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, T2, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2>(this CombinedResult<T1, SecretFactory, T2> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecretFactory, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2>(this CombinedResult<T1, T2, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, T2, T3, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3>(this CombinedResult<SecretFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, T2, T3, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3>(this CombinedResult<T1, SecretFactory, T2, T3> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecretFactory, T3, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3>(this CombinedResult<T1, T2, SecretFactory, T3> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecretFactory, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecretFactory, T1, T2, T3, T4, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3, T4>(this CombinedResult<SecretFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecretFactory, T2, T3, T4, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3, T4>(this CombinedResult<T1, SecretFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecretFactory, T3, T4, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecretFactory, T3, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecretFactory, T4, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecretFactory, T4> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecretFactory, InnerSecretGenerateSecretStringFactory> WithGenerateSecretString<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecretFactory> combinedResult, Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerateSecretString(combinedResult.T5, subFactoryAction));
}
