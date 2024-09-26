// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Oam;

public class LinkFactory(string resourceName = null, Action<Humidifier.Oam.Link> factoryAction = null) : ResourceFactory<Humidifier.Oam.Link>(resourceName)
{

    internal InnerLinkLinkConfigurationFactory LinkConfigurationFactory { get; set; }

    protected override Humidifier.Oam.Link Create()
    {
        var linkResult = CreateLink();
        factoryAction?.Invoke(linkResult);

        return linkResult;
    }

    private Humidifier.Oam.Link CreateLink()
    {
        var linkResult = new Humidifier.Oam.Link
        {
            GivenName = InputResourceName,
        };

        return linkResult;
    }
    public override void CreateChildren(Humidifier.Oam.Link result)
    {
        base.CreateChildren(result);

        result.LinkConfiguration ??= LinkConfigurationFactory?.Build();
    }

} // End Of Class

public static class LinkFactoryExtensions
{
    public static CombinedResult<LinkFactory, InnerLinkLinkConfigurationFactory> WithLinkConfiguration(this LinkFactory parentFactory, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null)
    {
        parentFactory.LinkConfigurationFactory = new InnerLinkLinkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkConfigurationFactory);
    }

    public static CombinedResult<LinkFactory, T1, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1>(this CombinedResult<LinkFactory, T1> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1>(this CombinedResult<T1, LinkFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LinkFactory, T1, T2, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2>(this CombinedResult<LinkFactory, T1, T2> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, T2, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2>(this CombinedResult<T1, LinkFactory, T2> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LinkFactory, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2>(this CombinedResult<T1, T2, LinkFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LinkFactory, T1, T2, T3, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3>(this CombinedResult<LinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, T2, T3, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3>(this CombinedResult<T1, LinkFactory, T2, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LinkFactory, T3, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, LinkFactory, T3> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LinkFactory, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, LinkFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LinkFactory, T1, T2, T3, T4, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3, T4>(this CombinedResult<LinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, T2, T3, T4, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, LinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LinkFactory, T3, T4, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, LinkFactory, T3, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LinkFactory, T4, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LinkFactory, T4> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LinkFactory, InnerLinkLinkConfigurationFactory> WithLinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LinkFactory> combinedResult, Action<Humidifier.Oam.LinkTypes.LinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkConfiguration(combinedResult.T5, subFactoryAction));
}
