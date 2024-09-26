// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterEncryptionConfigFactory(Action<Humidifier.EKS.ClusterTypes.EncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.EncryptionConfig>
{

    internal InnerClusterProviderFactory ProviderFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.EncryptionConfig Create()
    {
        var encryptionConfigResult = CreateEncryptionConfig();
        factoryAction?.Invoke(encryptionConfigResult);

        return encryptionConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.EncryptionConfig CreateEncryptionConfig()
    {
        var encryptionConfigResult = new Humidifier.EKS.ClusterTypes.EncryptionConfig();

        return encryptionConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.EncryptionConfig result)
    {
        base.CreateChildren(result);

        result.Provider ??= ProviderFactory?.Build();
    }

} // End Of Class

public static class InnerClusterEncryptionConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterEncryptionConfigFactory, InnerClusterProviderFactory> WithProvider(this InnerClusterEncryptionConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null)
    {
        parentFactory.ProviderFactory = new InnerClusterProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderFactory);
    }

    public static CombinedResult<InnerClusterEncryptionConfigFactory, T1, InnerClusterProviderFactory> WithProvider<T1>(this CombinedResult<InnerClusterEncryptionConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionConfigFactory, InnerClusterProviderFactory> WithProvider<T1>(this CombinedResult<T1, InnerClusterEncryptionConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionConfigFactory, T1, T2, InnerClusterProviderFactory> WithProvider<T1, T2>(this CombinedResult<InnerClusterEncryptionConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionConfigFactory, T2, InnerClusterProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, InnerClusterEncryptionConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionConfigFactory, InnerClusterProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, T2, InnerClusterEncryptionConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionConfigFactory, T1, T2, T3, InnerClusterProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<InnerClusterEncryptionConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionConfigFactory, T2, T3, InnerClusterProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, InnerClusterEncryptionConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionConfigFactory, T3, InnerClusterProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterEncryptionConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEncryptionConfigFactory, InnerClusterProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterEncryptionConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterEncryptionConfigFactory, T1, T2, T3, T4, InnerClusterProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<InnerClusterEncryptionConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterEncryptionConfigFactory, T2, T3, T4, InnerClusterProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterEncryptionConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterEncryptionConfigFactory, T3, T4, InnerClusterProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterEncryptionConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterEncryptionConfigFactory, T4, InnerClusterProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterEncryptionConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterEncryptionConfigFactory, InnerClusterProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterEncryptionConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T5, subFactoryAction));
}
