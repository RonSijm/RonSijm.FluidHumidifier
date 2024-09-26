// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerDocumentClassifierDocumentClassifierDocumentsFactory(Action<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierDocuments> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierDocuments>
{

    protected override Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierDocuments Create()
    {
        var documentClassifierDocumentsResult = CreateDocumentClassifierDocuments();
        factoryAction?.Invoke(documentClassifierDocumentsResult);

        return documentClassifierDocumentsResult;
    }

    private Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierDocuments CreateDocumentClassifierDocuments()
    {
        var documentClassifierDocumentsResult = new Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierDocuments();

        return documentClassifierDocumentsResult;
    }

} // End Of Class

public static class InnerDocumentClassifierDocumentClassifierDocumentsFactoryExtensions
{
}
