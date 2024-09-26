// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class VodSourceFactory(string resourceName = null, Action<Humidifier.MediaTailor.VodSource> factoryAction = null) : ResourceFactory<Humidifier.MediaTailor.VodSource>(resourceName)
{

    internal List<InnerVodSourceHttpPackageConfigurationFactory> HttpPackageConfigurationsFactories { get; set; } = [];

    protected override Humidifier.MediaTailor.VodSource Create()
    {
        var vodSourceResult = CreateVodSource();
        factoryAction?.Invoke(vodSourceResult);

        return vodSourceResult;
    }

    private Humidifier.MediaTailor.VodSource CreateVodSource()
    {
        var vodSourceResult = new Humidifier.MediaTailor.VodSource
        {
            GivenName = InputResourceName,
        };

        return vodSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.VodSource result)
    {
        base.CreateChildren(result);

        result.HttpPackageConfigurations = HttpPackageConfigurationsFactories.Any() ? HttpPackageConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class VodSourceFactoryExtensions
{
    public static CombinedResult<VodSourceFactory, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations(this VodSourceFactory parentFactory, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null)
    {
        var factory = new InnerVodSourceHttpPackageConfigurationFactory(subFactoryAction);
        parentFactory.HttpPackageConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<VodSourceFactory, T1, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1>(this CombinedResult<VodSourceFactory, T1> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VodSourceFactory, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1>(this CombinedResult<T1, VodSourceFactory> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VodSourceFactory, T1, T2, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2>(this CombinedResult<VodSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VodSourceFactory, T2, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2>(this CombinedResult<T1, VodSourceFactory, T2> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VodSourceFactory, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2>(this CombinedResult<T1, T2, VodSourceFactory> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VodSourceFactory, T1, T2, T3, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<VodSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VodSourceFactory, T2, T3, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<T1, VodSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VodSourceFactory, T3, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, VodSourceFactory, T3> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VodSourceFactory, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, VodSourceFactory> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VodSourceFactory, T1, T2, T3, T4, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<VodSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VodSourceFactory, T2, T3, T4, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, VodSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VodSourceFactory, T3, T4, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, VodSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VodSourceFactory, T4, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VodSourceFactory, T4> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VodSourceFactory, InnerVodSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VodSourceFactory> combinedResult, Action<Humidifier.MediaTailor.VodSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T5, subFactoryAction));
}
