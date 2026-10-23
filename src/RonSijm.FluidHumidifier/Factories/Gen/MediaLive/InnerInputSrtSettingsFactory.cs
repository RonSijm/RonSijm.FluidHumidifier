// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtSettingsFactory(Action<Humidifier.MediaLive.InputTypes.SrtSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtSettings>
{

    internal InnerInputSrtListenerSettingsFactory SrtListenerSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.InputTypes.SrtSettings Create()
    {
        var srtSettingsResult = CreateSrtSettings();
        factoryAction?.Invoke(srtSettingsResult);

        return srtSettingsResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtSettings CreateSrtSettings()
    {
        var srtSettingsResult = new Humidifier.MediaLive.InputTypes.SrtSettings();

        return srtSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.InputTypes.SrtSettings result)
    {
        base.CreateChildren(result);

        result.SrtListenerSettings ??= SrtListenerSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerInputSrtSettingsFactoryExtensions
{
    public static CombinedResult<InnerInputSrtSettingsFactory, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings(this InnerInputSrtSettingsFactory parentFactory, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null)
    {
        parentFactory.SrtListenerSettingsFactory = new InnerInputSrtListenerSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SrtListenerSettingsFactory);
    }

    public static CombinedResult<InnerInputSrtSettingsFactory, T1, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1>(this CombinedResult<InnerInputSrtSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsFactory, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1>(this CombinedResult<T1, InnerInputSrtSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtSettingsFactory, T1, T2, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2>(this CombinedResult<InnerInputSrtSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsFactory, T2, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2>(this CombinedResult<T1, InnerInputSrtSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtSettingsFactory, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2>(this CombinedResult<T1, T2, InnerInputSrtSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtSettingsFactory, T1, T2, T3, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<InnerInputSrtSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsFactory, T2, T3, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<T1, InnerInputSrtSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtSettingsFactory, T3, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerInputSrtSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtSettingsFactory, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInputSrtSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtSettingsFactory, T1, T2, T3, T4, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<InnerInputSrtSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsFactory, T2, T3, T4, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerInputSrtSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtSettingsFactory, T3, T4, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInputSrtSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtSettingsFactory, T4, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInputSrtSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInputSrtSettingsFactory, InnerInputSrtListenerSettingsFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInputSrtSettingsFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T5, subFactoryAction).T2);
}
