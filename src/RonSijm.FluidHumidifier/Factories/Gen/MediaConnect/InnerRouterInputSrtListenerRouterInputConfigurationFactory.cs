// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputSrtListenerRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration>
{

    internal InnerRouterInputSrtDecryptionConfigurationFactory DecryptionConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration Create()
    {
        var srtListenerRouterInputConfigurationResult = CreateSrtListenerRouterInputConfiguration();
        factoryAction?.Invoke(srtListenerRouterInputConfigurationResult);

        return srtListenerRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration CreateSrtListenerRouterInputConfiguration()
    {
        var srtListenerRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration();

        return srtListenerRouterInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration result)
    {
        base.CreateChildren(result);

        result.DecryptionConfiguration ??= DecryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputSrtListenerRouterInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration(this InnerRouterInputSrtListenerRouterInputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.DecryptionConfigurationFactory = new InnerRouterInputSrtDecryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DecryptionConfigurationFactory);
    }

    public static CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1>(this CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1>(this CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2>(this CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T2, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtListenerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputSrtListenerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T3, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSrtListenerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputSrtListenerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, T2, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputSrtListenerRouterInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T2, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T4, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputSrtListenerRouterInputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputSrtListenerRouterInputConfigurationFactory, InnerRouterInputSrtDecryptionConfigurationFactory> WithDecryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputSrtListenerRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
