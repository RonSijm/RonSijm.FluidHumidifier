// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class ContentAssociationFactory(string resourceName = null, Action<Humidifier.Wisdom.ContentAssociation> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.ContentAssociation>(resourceName)
{

    internal InnerContentAssociationContentAssociationContentsFactory AssociationFactory { get; set; }

    protected override Humidifier.Wisdom.ContentAssociation Create()
    {
        var contentAssociationResult = CreateContentAssociation();
        factoryAction?.Invoke(contentAssociationResult);

        return contentAssociationResult;
    }

    private Humidifier.Wisdom.ContentAssociation CreateContentAssociation()
    {
        var contentAssociationResult = new Humidifier.Wisdom.ContentAssociation
        {
            GivenName = InputResourceName,
        };

        return contentAssociationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.ContentAssociation result)
    {
        base.CreateChildren(result);

        result.Association ??= AssociationFactory?.Build();
    }

} // End Of Class

public static class ContentAssociationFactoryExtensions
{
    public static CombinedResult<ContentAssociationFactory, InnerContentAssociationContentAssociationContentsFactory> WithAssociation(this ContentAssociationFactory parentFactory, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null)
    {
        parentFactory.AssociationFactory = new InnerContentAssociationContentAssociationContentsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AssociationFactory);
    }

    public static CombinedResult<ContentAssociationFactory, T1, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1>(this CombinedResult<ContentAssociationFactory, T1> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContentAssociationFactory, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1>(this CombinedResult<T1, ContentAssociationFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ContentAssociationFactory, T1, T2, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2>(this CombinedResult<ContentAssociationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContentAssociationFactory, T2, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2>(this CombinedResult<T1, ContentAssociationFactory, T2> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContentAssociationFactory, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2>(this CombinedResult<T1, T2, ContentAssociationFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ContentAssociationFactory, T1, T2, T3, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3>(this CombinedResult<ContentAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContentAssociationFactory, T2, T3, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3>(this CombinedResult<T1, ContentAssociationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContentAssociationFactory, T3, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3>(this CombinedResult<T1, T2, ContentAssociationFactory, T3> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContentAssociationFactory, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContentAssociationFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ContentAssociationFactory, T1, T2, T3, T4, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<ContentAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContentAssociationFactory, T2, T3, T4, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, ContentAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContentAssociationFactory, T3, T4, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContentAssociationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContentAssociationFactory, T4, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContentAssociationFactory, T4> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ContentAssociationFactory, InnerContentAssociationContentAssociationContentsFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContentAssociationFactory> combinedResult, Action<Humidifier.Wisdom.ContentAssociationTypes.ContentAssociationContents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T5, subFactoryAction).T2);
}
