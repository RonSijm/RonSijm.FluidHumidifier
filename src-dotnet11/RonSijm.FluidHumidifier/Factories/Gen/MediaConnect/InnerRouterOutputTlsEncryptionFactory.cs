// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputTlsEncryptionFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption>
{

    internal InnerRouterOutputTlsEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption Create()
    {
        var tlsEncryptionResult = CreateTlsEncryption();
        factoryAction?.Invoke(tlsEncryptionResult);

        return tlsEncryptionResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption CreateTlsEncryption()
    {
        var tlsEncryptionResult = new Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption();

        return tlsEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputTlsEncryptionFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputTlsEncryptionFactory, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerRouterOutputTlsEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerRouterOutputTlsEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, T2, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, T2, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputTlsEncryptionFactory, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputTlsEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, T2, T3, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, T2, T3, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputTlsEncryptionFactory, T3, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputTlsEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputTlsEncryptionFactory, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputTlsEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, T2, T3, T4, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputTlsEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, T2, T3, T4, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputTlsEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputTlsEncryptionFactory, T3, T4, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputTlsEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputTlsEncryptionFactory, T4, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputTlsEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputTlsEncryptionFactory, InnerRouterOutputTlsEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputTlsEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
