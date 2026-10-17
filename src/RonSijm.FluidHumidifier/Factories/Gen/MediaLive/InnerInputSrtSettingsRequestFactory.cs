// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtSettingsRequestFactory(Action<Humidifier.MediaLive.InputTypes.SrtSettingsRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtSettingsRequest>
{

    internal InnerInputSrtListenerSettingsRequestFactory SrtListenerSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.InputTypes.SrtSettingsRequest Create()
    {
        var srtSettingsRequestResult = CreateSrtSettingsRequest();
        factoryAction?.Invoke(srtSettingsRequestResult);

        return srtSettingsRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtSettingsRequest CreateSrtSettingsRequest()
    {
        var srtSettingsRequestResult = new Humidifier.MediaLive.InputTypes.SrtSettingsRequest();

        return srtSettingsRequestResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.InputTypes.SrtSettingsRequest result)
    {
        base.CreateChildren(result);

        result.SrtListenerSettings ??= SrtListenerSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerInputSrtSettingsRequestFactoryExtensions
{
    public static CombinedResult<InnerInputSrtSettingsRequestFactory, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings(this InnerInputSrtSettingsRequestFactory parentFactory, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null)
    {
        parentFactory.SrtListenerSettingsFactory = new InnerInputSrtListenerSettingsRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SrtListenerSettingsFactory);
    }

    public static CombinedResult<InnerInputSrtSettingsRequestFactory, T1, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1>(this CombinedResult<InnerInputSrtSettingsRequestFactory, T1> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsRequestFactory, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1>(this CombinedResult<T1, InnerInputSrtSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtSettingsRequestFactory, T1, T2, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2>(this CombinedResult<InnerInputSrtSettingsRequestFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsRequestFactory, T2, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2>(this CombinedResult<T1, InnerInputSrtSettingsRequestFactory, T2> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtSettingsRequestFactory, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2>(this CombinedResult<T1, T2, InnerInputSrtSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtSettingsRequestFactory, T1, T2, T3, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<InnerInputSrtSettingsRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsRequestFactory, T2, T3, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<T1, InnerInputSrtSettingsRequestFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtSettingsRequestFactory, T3, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerInputSrtSettingsRequestFactory, T3> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtSettingsRequestFactory, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInputSrtSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInputSrtSettingsRequestFactory, T1, T2, T3, T4, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<InnerInputSrtSettingsRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInputSrtSettingsRequestFactory, T2, T3, T4, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerInputSrtSettingsRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInputSrtSettingsRequestFactory, T3, T4, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInputSrtSettingsRequestFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInputSrtSettingsRequestFactory, T4, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInputSrtSettingsRequestFactory, T4> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInputSrtSettingsRequestFactory, InnerInputSrtListenerSettingsRequestFactory> WithSrtListenerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInputSrtSettingsRequestFactory> combinedResult, Action<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSrtListenerSettings(combinedResult.T5, subFactoryAction).T2);
}
