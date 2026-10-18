// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class InnerWorkspaceIdpMetadataFactory(Action<Humidifier.Grafana.WorkspaceTypes.IdpMetadata> factoryAction = null) : SubResourceFactory<Humidifier.Grafana.WorkspaceTypes.IdpMetadata>
{

    protected override Humidifier.Grafana.WorkspaceTypes.IdpMetadata Create()
    {
        var idpMetadataResult = CreateIdpMetadata();
        factoryAction?.Invoke(idpMetadataResult);

        return idpMetadataResult;
    }

    private Humidifier.Grafana.WorkspaceTypes.IdpMetadata CreateIdpMetadata()
    {
        var idpMetadataResult = new Humidifier.Grafana.WorkspaceTypes.IdpMetadata();

        return idpMetadataResult;
    }

} // End Of Class

public static class InnerWorkspaceIdpMetadataFactoryExtensions
{
}
