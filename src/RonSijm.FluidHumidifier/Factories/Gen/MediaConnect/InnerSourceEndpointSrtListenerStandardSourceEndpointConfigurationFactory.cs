// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration>
{

    internal InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory EncryptionPassphraseFactory { get; set; }

    protected override Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration Create()
    {
        var srtListenerStandardSourceEndpointConfigurationResult = CreateSrtListenerStandardSourceEndpointConfiguration();
        factoryAction?.Invoke(srtListenerStandardSourceEndpointConfigurationResult);

        return srtListenerStandardSourceEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration CreateSrtListenerStandardSourceEndpointConfiguration()
    {
        var srtListenerStandardSourceEndpointConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration();

        return srtListenerStandardSourceEndpointConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionPassphrase ??= EncryptionPassphraseFactory?.Build();
    }

} // End Of Class

public static class InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase(this InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionPassphraseFactory = new InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionPassphraseFactory);
    }

    public static CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, T2, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T2, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, T2, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, T2, T3, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T2, T3, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T3, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, T2, T3, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T2, T3, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T3, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSourceEndpointSrtListenerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T5, subFactoryAction).T2);
}
