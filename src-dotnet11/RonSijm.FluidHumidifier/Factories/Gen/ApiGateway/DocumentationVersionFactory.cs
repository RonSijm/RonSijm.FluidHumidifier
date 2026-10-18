// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class DocumentationVersionFactory(string resourceName = null, Action<Humidifier.ApiGateway.DocumentationVersion> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.DocumentationVersion>(resourceName)
{

    protected override Humidifier.ApiGateway.DocumentationVersion Create()
    {
        var documentationVersionResult = CreateDocumentationVersion();
        factoryAction?.Invoke(documentationVersionResult);

        return documentationVersionResult;
    }

    private Humidifier.ApiGateway.DocumentationVersion CreateDocumentationVersion()
    {
        var documentationVersionResult = new Humidifier.ApiGateway.DocumentationVersion
        {
            GivenName = InputResourceName,
        };

        return documentationVersionResult;
    }

} // End Of Class

public static class DocumentationVersionFactoryExtensions
{
}
