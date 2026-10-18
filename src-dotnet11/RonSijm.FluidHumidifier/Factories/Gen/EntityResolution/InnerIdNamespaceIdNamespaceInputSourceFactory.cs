// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdNamespaceIdNamespaceInputSourceFactory(Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource>
{

    protected override Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource Create()
    {
        var idNamespaceInputSourceResult = CreateIdNamespaceInputSource();
        factoryAction?.Invoke(idNamespaceInputSourceResult);

        return idNamespaceInputSourceResult;
    }

    private Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource CreateIdNamespaceInputSource()
    {
        var idNamespaceInputSourceResult = new Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource();

        return idNamespaceInputSourceResult;
    }

} // End Of Class

public static class InnerIdNamespaceIdNamespaceInputSourceFactoryExtensions
{
}
