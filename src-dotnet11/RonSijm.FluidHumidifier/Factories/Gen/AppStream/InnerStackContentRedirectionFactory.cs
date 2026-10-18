// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackContentRedirectionFactory(Action<Humidifier.AppStream.StackTypes.ContentRedirection> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.ContentRedirection>
{

    internal InnerStackUrlRedirectionConfigFactory HostToClientFactory { get; set; }

    protected override Humidifier.AppStream.StackTypes.ContentRedirection Create()
    {
        var contentRedirectionResult = CreateContentRedirection();
        factoryAction?.Invoke(contentRedirectionResult);

        return contentRedirectionResult;
    }

    private Humidifier.AppStream.StackTypes.ContentRedirection CreateContentRedirection()
    {
        var contentRedirectionResult = new Humidifier.AppStream.StackTypes.ContentRedirection();

        return contentRedirectionResult;
    }
    public override void CreateChildren(Humidifier.AppStream.StackTypes.ContentRedirection result)
    {
        base.CreateChildren(result);

        result.HostToClient ??= HostToClientFactory?.Build();
    }

} // End Of Class

public static class InnerStackContentRedirectionFactoryExtensions
{
    public static CombinedResult<InnerStackContentRedirectionFactory, InnerStackUrlRedirectionConfigFactory> WithHostToClient(this InnerStackContentRedirectionFactory parentFactory, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null)
    {
        parentFactory.HostToClientFactory = new InnerStackUrlRedirectionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostToClientFactory);
    }

    public static CombinedResult<InnerStackContentRedirectionFactory, T1, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1>(this CombinedResult<InnerStackContentRedirectionFactory, T1> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostToClient(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStackContentRedirectionFactory, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1>(this CombinedResult<T1, InnerStackContentRedirectionFactory> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostToClient(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerStackContentRedirectionFactory, T1, T2, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2>(this CombinedResult<InnerStackContentRedirectionFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStackContentRedirectionFactory, T2, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2>(this CombinedResult<T1, InnerStackContentRedirectionFactory, T2> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStackContentRedirectionFactory, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2>(this CombinedResult<T1, T2, InnerStackContentRedirectionFactory> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerStackContentRedirectionFactory, T1, T2, T3, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3>(this CombinedResult<InnerStackContentRedirectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStackContentRedirectionFactory, T2, T3, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3>(this CombinedResult<T1, InnerStackContentRedirectionFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStackContentRedirectionFactory, T3, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3>(this CombinedResult<T1, T2, InnerStackContentRedirectionFactory, T3> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStackContentRedirectionFactory, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStackContentRedirectionFactory> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerStackContentRedirectionFactory, T1, T2, T3, T4, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3, T4>(this CombinedResult<InnerStackContentRedirectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStackContentRedirectionFactory, T2, T3, T4, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3, T4>(this CombinedResult<T1, InnerStackContentRedirectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStackContentRedirectionFactory, T3, T4, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStackContentRedirectionFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStackContentRedirectionFactory, T4, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStackContentRedirectionFactory, T4> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerStackContentRedirectionFactory, InnerStackUrlRedirectionConfigFactory> WithHostToClient<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStackContentRedirectionFactory> combinedResult, Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostToClient(combinedResult.T5, subFactoryAction).T2);
}
