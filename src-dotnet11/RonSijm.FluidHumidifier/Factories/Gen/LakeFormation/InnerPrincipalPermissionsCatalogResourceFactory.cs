// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsCatalogResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.CatalogResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.CatalogResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.CatalogResource Create()
    {
        var catalogResourceResult = CreateCatalogResource();
        factoryAction?.Invoke(catalogResourceResult);

        return catalogResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.CatalogResource CreateCatalogResource()
    {
        var catalogResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.CatalogResource();

        return catalogResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsCatalogResourceFactoryExtensions
{
}
