// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerContentAssociationContentAssociationContentsFactory(Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents>
{

    internal InnerContentAssociationAmazonConnectGuideAssociationDataFactory AmazonConnectGuideAssociationFactory { get; set; }

    protected override Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents Create()
    {
        var contentAssociationContentsResult = CreateContentAssociationContents();
        factoryAction?.Invoke(contentAssociationContentsResult);

        return contentAssociationContentsResult;
    }

    private Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents CreateContentAssociationContents()
    {
        var contentAssociationContentsResult = new Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents();

        return contentAssociationContentsResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents result)
    {
        base.CreateChildren(result);

        result.AmazonConnectGuideAssociation ??= AmazonConnectGuideAssociationFactory?.Build();
    }

} // End Of Class

public static class InnerContentAssociationContentAssociationContentsFactoryExtensions
{
    public static CombinedResult<InnerContentAssociationContentAssociationContentsFactory, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation(this InnerContentAssociationContentAssociationContentsFactory parentFactory, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null)
    {
        parentFactory.AmazonConnectGuideAssociationFactory = new InnerContentAssociationAmazonConnectGuideAssociationDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AmazonConnectGuideAssociationFactory);
    }

    public static CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1>(this CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1>(this CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, T2, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2>(this CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, T2, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2>(this CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, T2> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerContentAssociationContentAssociationContentsFactory, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2>(this CombinedResult<T1, T2, InnerContentAssociationContentAssociationContentsFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, T2, T3, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3>(this CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, T2, T3, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3>(this CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerContentAssociationContentAssociationContentsFactory, T3, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3>(this CombinedResult<T1, T2, InnerContentAssociationContentAssociationContentsFactory, T3> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerContentAssociationContentAssociationContentsFactory, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContentAssociationContentAssociationContentsFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, T2, T3, T4, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3, T4>(this CombinedResult<InnerContentAssociationContentAssociationContentsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, T2, T3, T4, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3, T4>(this CombinedResult<T1, InnerContentAssociationContentAssociationContentsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerContentAssociationContentAssociationContentsFactory, T3, T4, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContentAssociationContentAssociationContentsFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerContentAssociationContentAssociationContentsFactory, T4, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContentAssociationContentAssociationContentsFactory, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerContentAssociationContentAssociationContentsFactory, InnerContentAssociationAmazonConnectGuideAssociationDataFactory> WithAmazonConnectGuideAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContentAssociationContentAssociationContentsFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonConnectGuideAssociation(combinedResult.T5, subFactoryAction).T2);
}
