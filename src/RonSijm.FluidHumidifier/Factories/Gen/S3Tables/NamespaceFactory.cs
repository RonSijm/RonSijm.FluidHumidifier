// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class NamespaceFactory(string resourceName = null, Action<Humidifier.S3Tables.Namespace> factoryAction = null) : ResourceFactory<Humidifier.S3Tables.Namespace>(resourceName)
{

    protected override Humidifier.S3Tables.Namespace Create()
    {
        var namespaceResult = CreateNamespace();
        factoryAction?.Invoke(namespaceResult);

        return namespaceResult;
    }

    private Humidifier.S3Tables.Namespace CreateNamespace()
    {
        var namespaceResult = new Humidifier.S3Tables.Namespace
        {
            GivenName = InputResourceName,
        };

        return namespaceResult;
    }

} // End Of Class

public static class NamespaceFactoryExtensions
{
}
