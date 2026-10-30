// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration>
{

    internal InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory EncryptionPassphraseFactory { get; set; }

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration Create()
    {
        var srtCallerStandardDestinationEndpointConfigurationResult = CreateSrtCallerStandardDestinationEndpointConfiguration();
        factoryAction?.Invoke(srtCallerStandardDestinationEndpointConfigurationResult);

        return srtCallerStandardDestinationEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration CreateSrtCallerStandardDestinationEndpointConfiguration()
    {
        var srtCallerStandardDestinationEndpointConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration();

        return srtCallerStandardDestinationEndpointConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionPassphrase ??= EncryptionPassphraseFactory?.Build();
    }

} // End Of Class

public static class InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase(this InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionPassphraseFactory = new InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionPassphraseFactory);
    }

    public static CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1>(this CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, T2, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T2, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2>(this CombinedResult<T1, T2, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, T2, T3, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T2, T3, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T3, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, T2, T3, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T2, T3, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T3, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T4, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory, InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory> WithEncryptionPassphrase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDestinationEndpointSrtCallerStandardDestinationEndpointConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionPassphrase(combinedResult.T5, subFactoryAction).T2);
}
