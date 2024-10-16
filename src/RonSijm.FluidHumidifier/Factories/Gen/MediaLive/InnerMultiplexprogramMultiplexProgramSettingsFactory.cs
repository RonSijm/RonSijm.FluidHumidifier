// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexprogramMultiplexProgramSettingsFactory(Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings>
{

    internal InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory ServiceDescriptorFactory { get; set; }

    internal InnerMultiplexprogramMultiplexVideoSettingsFactory VideoSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings Create()
    {
        var multiplexProgramSettingsResult = CreateMultiplexProgramSettings();
        factoryAction?.Invoke(multiplexProgramSettingsResult);

        return multiplexProgramSettingsResult;
    }

    private Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings CreateMultiplexProgramSettings()
    {
        var multiplexProgramSettingsResult = new Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings();

        return multiplexProgramSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings result)
    {
        base.CreateChildren(result);

        result.ServiceDescriptor ??= ServiceDescriptorFactory?.Build();
        result.VideoSettings ??= VideoSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerMultiplexprogramMultiplexProgramSettingsFactoryExtensions
{
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor(this InnerMultiplexprogramMultiplexProgramSettingsFactory parentFactory, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null)
    {
        parentFactory.ServiceDescriptorFactory = new InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceDescriptorFactory);
    }

    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings(this InnerMultiplexprogramMultiplexProgramSettingsFactory parentFactory, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null)
    {
        parentFactory.VideoSettingsFactory = new InnerMultiplexprogramMultiplexVideoSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VideoSettingsFactory);
    }

    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3, T4, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3, T4>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3, T4, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3, T4, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory, T4, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory> WithServiceDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDescriptor(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3, T4, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3, T4>(this CombinedResult<InnerMultiplexprogramMultiplexProgramSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3, T4, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerMultiplexprogramMultiplexProgramSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3, T4, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMultiplexprogramMultiplexProgramSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory, T4, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMultiplexprogramMultiplexProgramSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMultiplexprogramMultiplexProgramSettingsFactory, InnerMultiplexprogramMultiplexVideoSettingsFactory> WithVideoSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMultiplexprogramMultiplexProgramSettingsFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSettings(combinedResult.T5, subFactoryAction));
}
