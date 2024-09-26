// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerDocumentDocumentRequiresFactory(Action<Humidifier.SSM.DocumentTypes.DocumentRequires> factoryAction = null) : SubResourceFactory<Humidifier.SSM.DocumentTypes.DocumentRequires>
{

    protected override Humidifier.SSM.DocumentTypes.DocumentRequires Create()
    {
        var documentRequiresResult = CreateDocumentRequires();
        factoryAction?.Invoke(documentRequiresResult);

        return documentRequiresResult;
    }

    private Humidifier.SSM.DocumentTypes.DocumentRequires CreateDocumentRequires()
    {
        var documentRequiresResult = new Humidifier.SSM.DocumentTypes.DocumentRequires();

        return documentRequiresResult;
    }

} // End Of Class

public static class InnerDocumentDocumentRequiresFactoryExtensions
{
}
