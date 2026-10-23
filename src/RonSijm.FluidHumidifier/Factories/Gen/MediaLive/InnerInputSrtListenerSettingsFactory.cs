// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtListenerSettingsFactory(Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtListenerSettings>
{

    internal InnerInputSrtListenerDecryptionFactory DecryptionFactory { get; set; }

    protected override Humidifier.MediaLive.InputTypes.SrtListenerSettings Create()
    {
        var srtListenerSettingsResult = CreateSrtListenerSettings();
        factoryAction?.Invoke(srtListenerSettingsResult);

        return srtListenerSettingsResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtListenerSettings CreateSrtListenerSettings()
    {
        var srtListenerSettingsResult = new Humidifier.MediaLive.InputTypes.SrtListenerSettings();

        return srtListenerSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.InputTypes.SrtListenerSettings result)
    {
        base.CreateChildren(result);

        result.Decryption ??= DecryptionFactory?.Build();
    }

} // End Of Class

public static class InnerInputSrtListenerSettingsFactoryExtensions
{
    public static CombinedResult<InnerInputSrtListenerSettingsFactory, InnerInputSrtListenerDecryptionFactory> WithDecryption(this InnerInputSrtListenerSettingsFactory parentFactory, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null)
    {
        parentFactory.DecryptionFactory = new InnerInputSrtListenerDecryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DecryptionFactory);
    }

    public static CombinedResult<InnerInputSrtListenerSettingsFactory, T1, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1>(this CombinedResult<InnerInputSrtListenerSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsFactory, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1>(this CombinedResult<T1, InnerInputSrtListenerSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtListenerSettingsFactory, T1, T2, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2>(this CombinedResult<InnerInputSrtListenerSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsFactory, T2, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2>(this CombinedResult<T1, InnerInputSrtListenerSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtListenerSettingsFactory, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2>(this CombinedResult<T1, T2, InnerInputSrtListenerSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtListenerSettingsFactory, T1, T2, T3, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<InnerInputSrtListenerSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsFactory, T2, T3, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, InnerInputSrtListenerSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtListenerSettingsFactory, T3, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerInputSrtListenerSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsFactory, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtListenerSettingsFactory, T1, T2, T3, T4, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<InnerInputSrtListenerSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtListenerSettingsFactory, T2, T3, T4, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerInputSrtListenerSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtListenerSettingsFactory, T3, T4, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInputSrtListenerSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsFactory, T4, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInputSrtListenerSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInputSrtListenerSettingsFactory, InnerInputSrtListenerDecryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInputSrtListenerSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T5, subFactoryAction).T2);
}
