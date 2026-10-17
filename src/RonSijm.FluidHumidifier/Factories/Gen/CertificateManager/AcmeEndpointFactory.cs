// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class AcmeEndpointFactory(string resourceName = null, Action<Humidifier.CertificateManager.AcmeEndpoint> factoryAction = null) : ResourceFactory<Humidifier.CertificateManager.AcmeEndpoint>(resourceName)
{

    internal List<InnerAcmeEndpointTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerAcmeEndpointCertificateAuthorityFactory CertificateAuthorityFactory { get; set; }

    protected override Humidifier.CertificateManager.AcmeEndpoint Create()
    {
        var acmeEndpointResult = CreateAcmeEndpoint();
        factoryAction?.Invoke(acmeEndpointResult);

        return acmeEndpointResult;
    }

    private Humidifier.CertificateManager.AcmeEndpoint CreateAcmeEndpoint()
    {
        var acmeEndpointResult = new Humidifier.CertificateManager.AcmeEndpoint
        {
            GivenName = InputResourceName,
        };

        return acmeEndpointResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.AcmeEndpoint result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.CertificateAuthority ??= CertificateAuthorityFactory?.Build();
    }

} // End Of Class

public static class AcmeEndpointFactoryExtensions
{
    public static CombinedResult<AcmeEndpointFactory, InnerAcmeEndpointTagsItemsFactory> WithTags(this AcmeEndpointFactory parentFactory, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerAcmeEndpointTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AcmeEndpointFactory, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority(this AcmeEndpointFactory parentFactory, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null)
    {
        parentFactory.CertificateAuthorityFactory = new InnerAcmeEndpointCertificateAuthorityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateAuthorityFactory);
    }

    public static CombinedResult<AcmeEndpointFactory, T1, InnerAcmeEndpointTagsItemsFactory> WithTags<T1>(this CombinedResult<AcmeEndpointFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, InnerAcmeEndpointTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, T2, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<AcmeEndpointFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, T2, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, AcmeEndpointFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeEndpointFactory, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, T2, T3, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<AcmeEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, T2, T3, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, AcmeEndpointFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeEndpointFactory, T3, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, AcmeEndpointFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeEndpointFactory, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, T2, T3, T4, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<AcmeEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, T2, T3, T4, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, AcmeEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeEndpointFactory, T3, T4, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AcmeEndpointFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeEndpointFactory, T4, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AcmeEndpointFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AcmeEndpointFactory, InnerAcmeEndpointTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1>(this CombinedResult<AcmeEndpointFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1>(this CombinedResult<T1, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, T2, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2>(this CombinedResult<AcmeEndpointFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, T2, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2>(this CombinedResult<T1, AcmeEndpointFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeEndpointFactory, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2>(this CombinedResult<T1, T2, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, T2, T3, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3>(this CombinedResult<AcmeEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, T2, T3, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3>(this CombinedResult<T1, AcmeEndpointFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeEndpointFactory, T3, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3>(this CombinedResult<T1, T2, AcmeEndpointFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeEndpointFactory, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3>(this CombinedResult<T1, T2, T3, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AcmeEndpointFactory, T1, T2, T3, T4, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<AcmeEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeEndpointFactory, T2, T3, T4, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, AcmeEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeEndpointFactory, T3, T4, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, T2, AcmeEndpointFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeEndpointFactory, T4, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AcmeEndpointFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AcmeEndpointFactory, InnerAcmeEndpointCertificateAuthorityFactory> WithCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AcmeEndpointFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateAuthority(combinedResult.T5, subFactoryAction).T2);
}
