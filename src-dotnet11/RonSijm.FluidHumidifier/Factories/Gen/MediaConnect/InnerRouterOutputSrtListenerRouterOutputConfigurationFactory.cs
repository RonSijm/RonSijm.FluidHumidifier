// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputSrtListenerRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration>
{

    internal InnerRouterOutputSrtEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration Create()
    {
        var srtListenerRouterOutputConfigurationResult = CreateSrtListenerRouterOutputConfiguration();
        factoryAction?.Invoke(srtListenerRouterOutputConfigurationResult);

        return srtListenerRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration CreateSrtListenerRouterOutputConfiguration()
    {
        var srtListenerRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration();

        return srtListenerRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputSrtListenerRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerRouterOutputSrtListenerRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerRouterOutputSrtEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T2, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory, InnerRouterOutputSrtEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputSrtListenerRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
