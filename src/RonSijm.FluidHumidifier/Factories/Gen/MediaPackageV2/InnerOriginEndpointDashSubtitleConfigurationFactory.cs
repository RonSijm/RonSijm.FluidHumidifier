// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashSubtitleConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration>
{

    internal InnerOriginEndpointDashTtmlConfigurationFactory TtmlConfigurationFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration Create()
    {
        var dashSubtitleConfigurationResult = CreateDashSubtitleConfiguration();
        factoryAction?.Invoke(dashSubtitleConfigurationResult);

        return dashSubtitleConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration CreateDashSubtitleConfiguration()
    {
        var dashSubtitleConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration();

        return dashSubtitleConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration result)
    {
        base.CreateChildren(result);

        result.TtmlConfiguration ??= TtmlConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointDashSubtitleConfigurationFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration(this InnerOriginEndpointDashSubtitleConfigurationFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null)
    {
        parentFactory.TtmlConfigurationFactory = new InnerOriginEndpointDashTtmlConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TtmlConfigurationFactory);
    }

    public static CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1>(this CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1>(this CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, T2, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2>(this CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, T2, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2>(this CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointDashSubtitleConfigurationFactory, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointDashSubtitleConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, T2, T3, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3>(this CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, T2, T3, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointDashSubtitleConfigurationFactory, T3, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointDashSubtitleConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashSubtitleConfigurationFactory, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashSubtitleConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, T2, T3, T4, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointDashSubtitleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, T2, T3, T4, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointDashSubtitleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointDashSubtitleConfigurationFactory, T3, T4, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointDashSubtitleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashSubtitleConfigurationFactory, T4, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashSubtitleConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashSubtitleConfigurationFactory, InnerOriginEndpointDashTtmlConfigurationFactory> WithTtmlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashSubtitleConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtmlConfiguration(combinedResult.T5, subFactoryAction).T2);
}
