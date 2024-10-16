// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Oam;

public class InnerLinkLinkConfigurationFactory(Action<Humidifier.Oam.LinkTypes.LinkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Oam.LinkTypes.LinkConfiguration>
{

    internal InnerLinkLinkFilterFactory LogGroupConfigurationFactory { get; set; }

    internal InnerLinkLinkFilterFactory MetricConfigurationFactory { get; set; }

    protected override Humidifier.Oam.LinkTypes.LinkConfiguration Create()
    {
        var linkConfigurationResult = CreateLinkConfiguration();
        factoryAction?.Invoke(linkConfigurationResult);

        return linkConfigurationResult;
    }

    private Humidifier.Oam.LinkTypes.LinkConfiguration CreateLinkConfiguration()
    {
        var linkConfigurationResult = new Humidifier.Oam.LinkTypes.LinkConfiguration();

        return linkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Oam.LinkTypes.LinkConfiguration result)
    {
        base.CreateChildren(result);

        result.LogGroupConfiguration ??= LogGroupConfigurationFactory?.Build();
        result.MetricConfiguration ??= MetricConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerLinkLinkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithLogGroupConfiguration(this InnerLinkLinkConfigurationFactory parentFactory, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null)
    {
        parentFactory.LogGroupConfigurationFactory = new InnerLinkLinkFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogGroupConfigurationFactory);
    }

    public static CombinedResult<InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithMetricConfiguration(this InnerLinkLinkConfigurationFactory parentFactory, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null)
    {
        parentFactory.MetricConfigurationFactory = new InnerLinkLinkFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricConfigurationFactory);
    }

    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3, T4, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3, T4, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3, T4, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory, T4, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithLogGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogGroupConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3, T4, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerLinkLinkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3, T4, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkLinkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3, T4, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkLinkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory, T4, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkLinkConfigurationFactory, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLinkLinkConfigurationFactory, InnerLinkLinkFilterFactory> WithMetricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkLinkConfigurationFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricConfiguration(combinedResult.T5, subFactoryAction));
}
