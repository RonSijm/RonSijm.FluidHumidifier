// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputMediaLiveTransitEncryptionFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption>
{

    internal InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption Create()
    {
        var mediaLiveTransitEncryptionResult = CreateMediaLiveTransitEncryption();
        factoryAction?.Invoke(mediaLiveTransitEncryptionResult);

        return mediaLiveTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption CreateMediaLiveTransitEncryption()
    {
        var mediaLiveTransitEncryptionResult = new Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption();

        return mediaLiveTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputMediaLiveTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerRouterOutputMediaLiveTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory, T4, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionFactory, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}
