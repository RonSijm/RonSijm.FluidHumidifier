// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class DocumentClassifierEndpointFactory(string resourceName = null, Action<Humidifier.Comprehend.DocumentClassifierEndpoint> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.DocumentClassifierEndpoint>(resourceName)
{

    protected override Humidifier.Comprehend.DocumentClassifierEndpoint Create()
    {
        var documentClassifierEndpointResult = CreateDocumentClassifierEndpoint();
        factoryAction?.Invoke(documentClassifierEndpointResult);

        return documentClassifierEndpointResult;
    }

    private Humidifier.Comprehend.DocumentClassifierEndpoint CreateDocumentClassifierEndpoint()
    {
        var documentClassifierEndpointResult = new Humidifier.Comprehend.DocumentClassifierEndpoint
        {
            GivenName = InputResourceName,
        };

        return documentClassifierEndpointResult;
    }

} // End Of Class

public static class DocumentClassifierEndpointFactoryExtensions
{
}
