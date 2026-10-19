// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationBeaconingConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.BeaconingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.BeaconingConfiguration>
{

    internal InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory ClientSideFactory { get; set; }

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.BeaconingConfiguration Create()
    {
        var beaconingConfigurationResult = CreateBeaconingConfiguration();
        factoryAction?.Invoke(beaconingConfigurationResult);

        return beaconingConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.BeaconingConfiguration CreateBeaconingConfiguration()
    {
        var beaconingConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.BeaconingConfiguration();

        return beaconingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.PlaybackConfigurationTypes.BeaconingConfiguration result)
    {
        base.CreateChildren(result);

        result.ClientSide ??= ClientSideFactory?.Build();
    }

} // End Of Class

public static class InnerPlaybackConfigurationBeaconingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide(this InnerPlaybackConfigurationBeaconingConfigurationFactory parentFactory, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null)
    {
        parentFactory.ClientSideFactory = new InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientSideFactory);
    }

    public static CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1>(this CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientSide(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1>(this CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientSide(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, T2, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2>(this CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, T2, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2>(this CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationBeaconingConfigurationFactory, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2>(this CombinedResult<T1, T2, InnerPlaybackConfigurationBeaconingConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, T2, T3, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3>(this CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, T2, T3, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3>(this CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationBeaconingConfigurationFactory, T3, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3>(this CombinedResult<T1, T2, InnerPlaybackConfigurationBeaconingConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationBeaconingConfigurationFactory, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationBeaconingConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, T2, T3, T4, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3, T4>(this CombinedResult<InnerPlaybackConfigurationBeaconingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, T2, T3, T4, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3, T4>(this CombinedResult<T1, InnerPlaybackConfigurationBeaconingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationBeaconingConfigurationFactory, T3, T4, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPlaybackConfigurationBeaconingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationBeaconingConfigurationFactory, T4, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationBeaconingConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationBeaconingConfigurationFactory, InnerPlaybackConfigurationClientSideBeaconingConfigurationFactory> WithClientSide<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationBeaconingConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ClientSideBeaconingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSide(combinedResult.T5, subFactoryAction).T2);
}
