// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class AcmeExternalAccountBindingFactory(string resourceName = null, Action<Humidifier.CertificateManager.AcmeExternalAccountBinding> factoryAction = null) : ResourceFactory<Humidifier.CertificateManager.AcmeExternalAccountBinding>(resourceName)
{

    internal List<InnerAcmeExternalAccountBindingTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerAcmeExternalAccountBindingExpirationFactory ExpirationFactory { get; set; }

    protected override Humidifier.CertificateManager.AcmeExternalAccountBinding Create()
    {
        var acmeExternalAccountBindingResult = CreateAcmeExternalAccountBinding();
        factoryAction?.Invoke(acmeExternalAccountBindingResult);

        return acmeExternalAccountBindingResult;
    }

    private Humidifier.CertificateManager.AcmeExternalAccountBinding CreateAcmeExternalAccountBinding()
    {
        var acmeExternalAccountBindingResult = new Humidifier.CertificateManager.AcmeExternalAccountBinding
        {
            GivenName = InputResourceName,
        };

        return acmeExternalAccountBindingResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.AcmeExternalAccountBinding result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Expiration ??= ExpirationFactory?.Build();
    }

} // End Of Class

public static class AcmeExternalAccountBindingFactoryExtensions
{
    public static CombinedResult<AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags(this AcmeExternalAccountBindingFactory parentFactory, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerAcmeExternalAccountBindingTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration(this AcmeExternalAccountBindingFactory parentFactory, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null)
    {
        parentFactory.ExpirationFactory = new InnerAcmeExternalAccountBindingExpirationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExpirationFactory);
    }

    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1>(this CombinedResult<AcmeExternalAccountBindingFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<AcmeExternalAccountBindingFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, AcmeExternalAccountBindingFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3, T4, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3, T4, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3, T4, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory, T4, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1>(this CombinedResult<AcmeExternalAccountBindingFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1>(this CombinedResult<T1, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2>(this CombinedResult<AcmeExternalAccountBindingFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2>(this CombinedResult<T1, AcmeExternalAccountBindingFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2>(this CombinedResult<T1, T2, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3, T4, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<AcmeExternalAccountBindingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3, T4, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, AcmeExternalAccountBindingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3, T4, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AcmeExternalAccountBindingFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory, T4, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AcmeExternalAccountBindingFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AcmeExternalAccountBindingFactory, InnerAcmeExternalAccountBindingExpirationFactory> WithExpiration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AcmeExternalAccountBindingFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiration(combinedResult.T5, subFactoryAction).T2);
}
