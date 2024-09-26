// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexprogramMultiplexVideoSettingsFactory(Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings>
{

    internal InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory StatmuxSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings Create()
    {
        var multiplexVideoSettingsResult = CreateMultiplexVideoSettings();
        factoryAction?.Invoke(multiplexVideoSettingsResult);

        return multiplexVideoSettingsResult;
    }

    private Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings CreateMultiplexVideoSettings()
    {
        var multiplexVideoSettingsResult = new Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings();

        return multiplexVideoSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings result)
    {
        base.CreateChildren(result);

        result.StatmuxSettings ??= StatmuxSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerMultiplexprogramMultiplexVideoSettingsFactoryExtensions
{
    public static CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings(this InnerMultiplexprogramMultiplexVideoSettingsFactory parentFactory, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null)
    {
        parentFactory.StatmuxSettingsFactory = new InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatmuxSettingsFactory);
    }

    public static CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1>(this CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1>(this CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, T2, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2>(this CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, T2, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2>(this CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, T2, T3, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3>(this CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, T2, T3, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3>(this CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory, T3, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, T2, T3, T4, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3, T4>(this CombinedResult<InnerMultiplexprogramMultiplexVideoSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, T2, T3, T4, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerMultiplexprogramMultiplexVideoSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory, T3, T4, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory, T4, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMultiplexprogramMultiplexVideoSettingsFactory, InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory> WithStatmuxSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMultiplexprogramMultiplexVideoSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatmuxSettings(combinedResult.T5, subFactoryAction));
}
