// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class AcmeDomainValidationFactory(string resourceName = null, Action<Humidifier.CertificateManager.AcmeDomainValidation> factoryAction = null) : ResourceFactory<Humidifier.CertificateManager.AcmeDomainValidation>(resourceName)
{

    internal List<InnerAcmeDomainValidationTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerAcmeDomainValidationPrevalidationOptionsFactory PrevalidationOptionsFactory { get; set; }

    protected override Humidifier.CertificateManager.AcmeDomainValidation Create()
    {
        var acmeDomainValidationResult = CreateAcmeDomainValidation();
        factoryAction?.Invoke(acmeDomainValidationResult);

        return acmeDomainValidationResult;
    }

    private Humidifier.CertificateManager.AcmeDomainValidation CreateAcmeDomainValidation()
    {
        var acmeDomainValidationResult = new Humidifier.CertificateManager.AcmeDomainValidation
        {
            GivenName = InputResourceName,
        };

        return acmeDomainValidationResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.AcmeDomainValidation result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.PrevalidationOptions ??= PrevalidationOptionsFactory?.Build();
    }

} // End Of Class

public static class AcmeDomainValidationFactoryExtensions
{
    public static CombinedResult<AcmeDomainValidationFactory, InnerAcmeDomainValidationTagsItemsFactory> WithTags(this AcmeDomainValidationFactory parentFactory, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerAcmeDomainValidationTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AcmeDomainValidationFactory, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions(this AcmeDomainValidationFactory parentFactory, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null)
    {
        parentFactory.PrevalidationOptionsFactory = new InnerAcmeDomainValidationPrevalidationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrevalidationOptionsFactory);
    }

    public static CombinedResult<AcmeDomainValidationFactory, T1, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1>(this CombinedResult<AcmeDomainValidationFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, T2, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<AcmeDomainValidationFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, T2, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, AcmeDomainValidationFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeDomainValidationFactory, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, T2, T3, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<AcmeDomainValidationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, T2, T3, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, AcmeDomainValidationFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeDomainValidationFactory, T3, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, AcmeDomainValidationFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeDomainValidationFactory, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, T2, T3, T4, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<AcmeDomainValidationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, T2, T3, T4, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, AcmeDomainValidationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeDomainValidationFactory, T3, T4, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AcmeDomainValidationFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeDomainValidationFactory, T4, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AcmeDomainValidationFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AcmeDomainValidationFactory, InnerAcmeDomainValidationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1>(this CombinedResult<AcmeDomainValidationFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1>(this CombinedResult<T1, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2>(this CombinedResult<AcmeDomainValidationFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2>(this CombinedResult<T1, AcmeDomainValidationFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeDomainValidationFactory, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2>(this CombinedResult<T1, T2, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, T2, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3>(this CombinedResult<AcmeDomainValidationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, T2, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3>(this CombinedResult<T1, AcmeDomainValidationFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeDomainValidationFactory, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, AcmeDomainValidationFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeDomainValidationFactory, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AcmeDomainValidationFactory, T1, T2, T3, T4, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3, T4>(this CombinedResult<AcmeDomainValidationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AcmeDomainValidationFactory, T2, T3, T4, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, AcmeDomainValidationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AcmeDomainValidationFactory, T3, T4, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AcmeDomainValidationFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AcmeDomainValidationFactory, T4, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AcmeDomainValidationFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AcmeDomainValidationFactory, InnerAcmeDomainValidationPrevalidationOptionsFactory> WithPrevalidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AcmeDomainValidationFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrevalidationOptions(combinedResult.T5, subFactoryAction).T2);
}
