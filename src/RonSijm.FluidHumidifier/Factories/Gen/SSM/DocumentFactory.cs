// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class DocumentFactory(string resourceName = null, Action<Humidifier.SSM.Document> factoryAction = null) : ResourceFactory<Humidifier.SSM.Document>(resourceName)
{

    internal List<InnerDocumentDocumentRequiresFactory> RequiresFactories { get; set; } = [];

    internal List<InnerDocumentAttachmentsSourceFactory> AttachmentsFactories { get; set; } = [];

    protected override Humidifier.SSM.Document Create()
    {
        var documentResult = CreateDocument();
        factoryAction?.Invoke(documentResult);

        return documentResult;
    }

    private Humidifier.SSM.Document CreateDocument()
    {
        var documentResult = new Humidifier.SSM.Document
        {
            GivenName = InputResourceName,
        };

        return documentResult;
    }
    public override void CreateChildren(Humidifier.SSM.Document result)
    {
        base.CreateChildren(result);

        result.Requires = RequiresFactories.Any() ? RequiresFactories.Select(x => x.Build()).ToList() : null;
        result.Attachments = AttachmentsFactories.Any() ? AttachmentsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DocumentFactoryExtensions
{
    public static CombinedResult<DocumentFactory, InnerDocumentDocumentRequiresFactory> WithRequires(this DocumentFactory parentFactory, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null)
    {
        var factory = new InnerDocumentDocumentRequiresFactory(subFactoryAction);
        parentFactory.RequiresFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DocumentFactory, InnerDocumentAttachmentsSourceFactory> WithAttachments(this DocumentFactory parentFactory, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null)
    {
        var factory = new InnerDocumentAttachmentsSourceFactory(subFactoryAction);
        parentFactory.AttachmentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DocumentFactory, T1, InnerDocumentDocumentRequiresFactory> WithRequires<T1>(this CombinedResult<DocumentFactory, T1> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequires(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, InnerDocumentDocumentRequiresFactory> WithRequires<T1>(this CombinedResult<T1, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequires(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, T2, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2>(this CombinedResult<DocumentFactory, T1, T2> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, T2, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2>(this CombinedResult<T1, DocumentFactory, T2> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentFactory, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2>(this CombinedResult<T1, T2, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, T2, T3, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3>(this CombinedResult<DocumentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, T2, T3, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3>(this CombinedResult<T1, DocumentFactory, T2, T3> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentFactory, T3, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3>(this CombinedResult<T1, T2, DocumentFactory, T3> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DocumentFactory, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3>(this CombinedResult<T1, T2, T3, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, T2, T3, T4, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3, T4>(this CombinedResult<DocumentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, T2, T3, T4, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3, T4>(this CombinedResult<T1, DocumentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentFactory, T3, T4, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3, T4>(this CombinedResult<T1, T2, DocumentFactory, T3, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DocumentFactory, T4, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DocumentFactory, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DocumentFactory, InnerDocumentDocumentRequiresFactory> WithRequires<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.DocumentRequires> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequires(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1>(this CombinedResult<DocumentFactory, T1> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1>(this CombinedResult<T1, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, T2, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2>(this CombinedResult<DocumentFactory, T1, T2> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, T2, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2>(this CombinedResult<T1, DocumentFactory, T2> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentFactory, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2>(this CombinedResult<T1, T2, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, T2, T3, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3>(this CombinedResult<DocumentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, T2, T3, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3>(this CombinedResult<T1, DocumentFactory, T2, T3> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentFactory, T3, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3>(this CombinedResult<T1, T2, DocumentFactory, T3> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DocumentFactory, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3>(this CombinedResult<T1, T2, T3, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DocumentFactory, T1, T2, T3, T4, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<DocumentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DocumentFactory, T2, T3, T4, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, DocumentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DocumentFactory, T3, T4, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, T2, DocumentFactory, T3, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DocumentFactory, T4, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DocumentFactory, T4> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DocumentFactory, InnerDocumentAttachmentsSourceFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DocumentFactory> combinedResult, Action<Humidifier.SSM.DocumentTypes.AttachmentsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T5, subFactoryAction));
}
