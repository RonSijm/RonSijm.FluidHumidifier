// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class NamespaceFactory(string resourceName = null, Action<Humidifier.SCN.Namespace> factoryAction = null) : ResourceFactory<Humidifier.SCN.Namespace>(resourceName)
{

    protected override Humidifier.SCN.Namespace Create()
    {
        var namespaceResult = CreateNamespace();
        factoryAction?.Invoke(namespaceResult);

        return namespaceResult;
    }

    private Humidifier.SCN.Namespace CreateNamespace()
    {
        var namespaceResult = new Humidifier.SCN.Namespace
        {
            GivenName = InputResourceName,
        };

        return namespaceResult;
    }

} // End Of Class

public static class NamespaceFactoryExtensions
{
}
