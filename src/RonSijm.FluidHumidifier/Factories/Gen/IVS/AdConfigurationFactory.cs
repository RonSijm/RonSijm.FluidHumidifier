// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class AdConfigurationFactory(string resourceName = null, Action<Humidifier.IVS.AdConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IVS.AdConfiguration>(resourceName)
{

    internal List<InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> MediaTailorPlaybackConfigurationsFactories { get; set; } = [];

    internal InnerAdConfigurationPostRollConfigurationFactory PostRollConfigurationFactory { get; set; }

    protected override Humidifier.IVS.AdConfiguration Create()
    {
        var adConfigurationResult = CreateAdConfiguration();
        factoryAction?.Invoke(adConfigurationResult);

        return adConfigurationResult;
    }

    private Humidifier.IVS.AdConfiguration CreateAdConfiguration()
    {
        var adConfigurationResult = new Humidifier.IVS.AdConfiguration
        {
            GivenName = InputResourceName,
        };

        return adConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.AdConfiguration result)
    {
        base.CreateChildren(result);

        result.MediaTailorPlaybackConfigurations = MediaTailorPlaybackConfigurationsFactories.Any() ? MediaTailorPlaybackConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.PostRollConfiguration ??= PostRollConfigurationFactory?.Build();
    }

} // End Of Class

public static class AdConfigurationFactoryExtensions
{
    public static CombinedResult<AdConfigurationFactory, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations(this AdConfigurationFactory parentFactory, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null)
    {
        var factory = new InnerAdConfigurationMediaTailorPlaybackConfigurationFactory(subFactoryAction);
        parentFactory.MediaTailorPlaybackConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AdConfigurationFactory, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration(this AdConfigurationFactory parentFactory, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null)
    {
        parentFactory.PostRollConfigurationFactory = new InnerAdConfigurationPostRollConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PostRollConfigurationFactory);
    }

    public static CombinedResult<AdConfigurationFactory, T1, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1>(this CombinedResult<AdConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1>(this CombinedResult<T1, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, T2, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2>(this CombinedResult<AdConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, T2, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2>(this CombinedResult<T1, AdConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AdConfigurationFactory, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2>(this CombinedResult<T1, T2, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, T2, T3, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3>(this CombinedResult<AdConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, T2, T3, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3>(this CombinedResult<T1, AdConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AdConfigurationFactory, T3, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, AdConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AdConfigurationFactory, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, T2, T3, T4, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3, T4>(this CombinedResult<AdConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, T2, T3, T4, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, AdConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AdConfigurationFactory, T3, T4, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, AdConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AdConfigurationFactory, T4, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AdConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AdConfigurationFactory, InnerAdConfigurationMediaTailorPlaybackConfigurationFactory> WithMediaTailorPlaybackConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaTailorPlaybackConfigurations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1>(this CombinedResult<AdConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1>(this CombinedResult<T1, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, T2, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2>(this CombinedResult<AdConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, T2, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2>(this CombinedResult<T1, AdConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AdConfigurationFactory, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2>(this CombinedResult<T1, T2, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, T2, T3, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3>(this CombinedResult<AdConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, T2, T3, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3>(this CombinedResult<T1, AdConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AdConfigurationFactory, T3, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AdConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AdConfigurationFactory, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AdConfigurationFactory, T1, T2, T3, T4, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3, T4>(this CombinedResult<AdConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AdConfigurationFactory, T2, T3, T4, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AdConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AdConfigurationFactory, T3, T4, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AdConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AdConfigurationFactory, T4, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AdConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AdConfigurationFactory, InnerAdConfigurationPostRollConfigurationFactory> WithPostRollConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AdConfigurationFactory> combinedResult, Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPostRollConfiguration(combinedResult.T5, subFactoryAction).T2);
}
