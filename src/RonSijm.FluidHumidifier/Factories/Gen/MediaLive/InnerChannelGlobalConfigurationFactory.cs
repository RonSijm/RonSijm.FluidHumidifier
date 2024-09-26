// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelGlobalConfigurationFactory(Action<Humidifier.MediaLive.ChannelTypes.GlobalConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.GlobalConfiguration>
{

    internal InnerChannelOutputLockingSettingsFactory OutputLockingSettingsFactory { get; set; }

    internal InnerChannelInputLossBehaviorFactory InputLossBehaviorFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.GlobalConfiguration Create()
    {
        var globalConfigurationResult = CreateGlobalConfiguration();
        factoryAction?.Invoke(globalConfigurationResult);

        return globalConfigurationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.GlobalConfiguration CreateGlobalConfiguration()
    {
        var globalConfigurationResult = new Humidifier.MediaLive.ChannelTypes.GlobalConfiguration();

        return globalConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.GlobalConfiguration result)
    {
        base.CreateChildren(result);

        result.OutputLockingSettings ??= OutputLockingSettingsFactory?.Build();
        result.InputLossBehavior ??= InputLossBehaviorFactory?.Build();
    }

} // End Of Class

public static class InnerChannelGlobalConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings(this InnerChannelGlobalConfigurationFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null)
    {
        parentFactory.OutputLockingSettingsFactory = new InnerChannelOutputLockingSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputLockingSettingsFactory);
    }

    public static CombinedResult<InnerChannelGlobalConfigurationFactory, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior(this InnerChannelGlobalConfigurationFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null)
    {
        parentFactory.InputLossBehaviorFactory = new InnerChannelInputLossBehaviorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputLossBehaviorFactory);
    }

    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3, T4, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3, T4, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3, T4, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory, T4, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelGlobalConfigurationFactory, InnerChannelOutputLockingSettingsFactory> WithOutputLockingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputLockingSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2>(this CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3, T4, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3, T4>(this CombinedResult<InnerChannelGlobalConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3, T4, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelGlobalConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3, T4, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelGlobalConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory, T4, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelGlobalConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelGlobalConfigurationFactory, InnerChannelInputLossBehaviorFactory> WithInputLossBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelGlobalConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossBehavior(combinedResult.T5, subFactoryAction));
}
