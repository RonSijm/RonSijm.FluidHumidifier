// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration>
{

    internal InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory EncryptionPassphraseFactory { get; set; }

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration Create()
    {
        var srtListenerStandardDestinationEndpointConfigurationResult = CreateSrtListenerStandardDestinationEndpointConfiguration();
        factoryAction?.Invoke(srtListenerStandardDestinationEndpointConfigurationResult);

        return srtListenerStandardDestinationEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration CreateSrtListenerStandardDestinationEndpointConfiguration()
    {
        var srtListenerStandardDestinationEndpointConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration();

        return srtListenerStandardDestinationEndpointConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionPassphrase ??= EncryptionPassphraseFactory?.Build();
    }

} // End Of Class

public static class InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase(this InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionPassphraseFactory = new InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionPassphraseFactory);
    }

    public static CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, T2, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T2, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, T2, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, T2, T3, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T2, T3, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T3, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, T2, T3, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T2, T3, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T3, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDestinationEndpointSrtListenerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T5, subFactoryAction).T2);
}
