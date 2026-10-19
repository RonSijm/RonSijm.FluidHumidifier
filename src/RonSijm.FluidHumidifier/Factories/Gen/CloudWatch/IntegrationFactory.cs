// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.CloudWatch.Integration> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.Integration>(resourceName)
{

    internal List<InnerIntegrationTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerIntegrationIntegrationCredentialFactory CredentialFactory { get; set; }

    protected override Humidifier.CloudWatch.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.CloudWatch.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.CloudWatch.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.Integration result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Credential ??= CredentialFactory?.Build();
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
    public static CombinedResult<IntegrationFactory, InnerIntegrationTagsItemsFactory> WithTags(this IntegrationFactory parentFactory, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerIntegrationTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IntegrationFactory, InnerIntegrationIntegrationCredentialFactory> WithCredential(this IntegrationFactory parentFactory, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null)
    {
        parentFactory.CredentialFactory = new InnerIntegrationIntegrationCredentialFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialFactory);
    }

    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationTagsItemsFactory> WithTags<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationIntegrationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T5, subFactoryAction).T2);
}
