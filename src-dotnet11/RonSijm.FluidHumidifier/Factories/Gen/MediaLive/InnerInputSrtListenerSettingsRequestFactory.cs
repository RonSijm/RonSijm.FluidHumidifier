// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtListenerSettingsRequestFactory(Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest>
{

    internal InnerInputSrtListenerDecryptionRequestFactory DecryptionFactory { get; set; }

    protected override Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest Create()
    {
        var srtListenerSettingsRequestResult = CreateSrtListenerSettingsRequest();
        factoryAction?.Invoke(srtListenerSettingsRequestResult);

        return srtListenerSettingsRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest CreateSrtListenerSettingsRequest()
    {
        var srtListenerSettingsRequestResult = new Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest();

        return srtListenerSettingsRequestResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest result)
    {
        base.CreateChildren(result);

        result.Decryption ??= DecryptionFactory?.Build();
    }

} // End Of Class

public static class InnerInputSrtListenerSettingsRequestFactoryExtensions
{
    public static CombinedResult<InnerInputSrtListenerSettingsRequestFactory, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption(this InnerInputSrtListenerSettingsRequestFactory parentFactory, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null)
    {
        parentFactory.DecryptionFactory = new InnerInputSrtListenerDecryptionRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DecryptionFactory);
    }

    public static CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1>(this CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1>(this CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, T2, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2>(this CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, T2, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2>(this CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtListenerSettingsRequestFactory, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2>(this CombinedResult<T1, T2, InnerInputSrtListenerSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, T2, T3, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3>(this CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, T2, T3, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtListenerSettingsRequestFactory, T3, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerInputSrtListenerSettingsRequestFactory, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsRequestFactory, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, T2, T3, T4, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<InnerInputSrtListenerSettingsRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, T2, T3, T4, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerInputSrtListenerSettingsRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtListenerSettingsRequestFactory, T3, T4, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInputSrtListenerSettingsRequestFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsRequestFactory, T4, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsRequestFactory, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInputSrtListenerSettingsRequestFactory, InnerInputSrtListenerDecryptionRequestFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInputSrtListenerSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T5, subFactoryAction).T2);
}
