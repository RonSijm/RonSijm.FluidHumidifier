// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputRouterInputTransitEncryptionFactory(Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption>
{

    internal InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption Create()
    {
        var routerInputTransitEncryptionResult = CreateRouterInputTransitEncryption();
        factoryAction?.Invoke(routerInputTransitEncryptionResult);

        return routerInputTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption CreateRouterInputTransitEncryption()
    {
        var routerInputTransitEncryptionResult = new Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption();

        return routerInputTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputRouterInputTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerRouterInputRouterInputTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, T2, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, T2, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputRouterInputTransitEncryptionFactory, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputRouterInputTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, T2, T3, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, T2, T3, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputRouterInputTransitEncryptionFactory, T3, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputRouterInputTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputRouterInputTransitEncryptionFactory, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputRouterInputTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, T2, T3, T4, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputRouterInputTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, T2, T3, T4, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputRouterInputTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputRouterInputTransitEncryptionFactory, T3, T4, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputRouterInputTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputRouterInputTransitEncryptionFactory, T4, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputRouterInputTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputRouterInputTransitEncryptionFactory, InnerRouterInputRouterInputTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputRouterInputTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}
