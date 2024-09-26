// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class LinkFactory(string resourceName = null, Action<Humidifier.NetworkManager.Link> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.Link>(resourceName)
{

    internal InnerLinkBandwidthFactory BandwidthFactory { get; set; }

    protected override Humidifier.NetworkManager.Link Create()
    {
        var linkResult = CreateLink();
        factoryAction?.Invoke(linkResult);

        return linkResult;
    }

    private Humidifier.NetworkManager.Link CreateLink()
    {
        var linkResult = new Humidifier.NetworkManager.Link
        {
            GivenName = InputResourceName,
        };

        return linkResult;
    }
    public override void CreateChildren(Humidifier.NetworkManager.Link result)
    {
        base.CreateChildren(result);

        result.Bandwidth ??= BandwidthFactory?.Build();
    }

} // End Of Class

public static class LinkFactoryExtensions
{
    public static CombinedResult<LinkFactory, InnerLinkBandwidthFactory> WithBandwidth(this LinkFactory parentFactory, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null)
    {
        parentFactory.BandwidthFactory = new InnerLinkBandwidthFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BandwidthFactory);
    }

    public static CombinedResult<LinkFactory, T1, InnerLinkBandwidthFactory> WithBandwidth<T1>(this CombinedResult<LinkFactory, T1> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, InnerLinkBandwidthFactory> WithBandwidth<T1>(this CombinedResult<T1, LinkFactory> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LinkFactory, T1, T2, InnerLinkBandwidthFactory> WithBandwidth<T1, T2>(this CombinedResult<LinkFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, T2, InnerLinkBandwidthFactory> WithBandwidth<T1, T2>(this CombinedResult<T1, LinkFactory, T2> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LinkFactory, InnerLinkBandwidthFactory> WithBandwidth<T1, T2>(this CombinedResult<T1, T2, LinkFactory> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LinkFactory, T1, T2, T3, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<LinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, T2, T3, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<T1, LinkFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LinkFactory, T3, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<T1, T2, LinkFactory, T3> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LinkFactory, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<T1, T2, T3, LinkFactory> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LinkFactory, T1, T2, T3, T4, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<LinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LinkFactory, T2, T3, T4, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, LinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LinkFactory, T3, T4, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, T2, LinkFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LinkFactory, T4, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LinkFactory, T4> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LinkFactory, InnerLinkBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LinkFactory> combinedResult, Action<Humidifier.NetworkManager.LinkTypes.Bandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T5, subFactoryAction));
}
