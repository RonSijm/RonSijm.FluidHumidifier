// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration>
{

    internal InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory EncryptionPassphraseFactory { get; set; }

    protected override Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration Create()
    {
        var srtCallerStandardSourceEndpointConfigurationResult = CreateSrtCallerStandardSourceEndpointConfiguration();
        factoryAction?.Invoke(srtCallerStandardSourceEndpointConfigurationResult);

        return srtCallerStandardSourceEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration CreateSrtCallerStandardSourceEndpointConfiguration()
    {
        var srtCallerStandardSourceEndpointConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration();

        return srtCallerStandardSourceEndpointConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionPassphrase ??= EncryptionPassphraseFactory?.Build();
    }

} // End Of Class

public static class InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase(this InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionPassphraseFactory = new InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionPassphraseFactory);
    }

    public static CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, T2, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T2, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, T2, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, T2, T3, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T2, T3, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T3, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, T2, T3, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T2, T3, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T3, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T4, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory, InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSourceEndpointSrtCallerStandardSourceEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T5, subFactoryAction).T2);
}
