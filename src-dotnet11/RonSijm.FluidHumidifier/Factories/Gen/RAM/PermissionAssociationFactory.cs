// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class PermissionAssociationFactory(string resourceName = null, Action<Humidifier.RAM.PermissionAssociation> factoryAction = null) : ResourceFactory<Humidifier.RAM.PermissionAssociation>(resourceName)
{

    protected override Humidifier.RAM.PermissionAssociation Create()
    {
        var permissionAssociationResult = CreatePermissionAssociation();
        factoryAction?.Invoke(permissionAssociationResult);

        return permissionAssociationResult;
    }

    private Humidifier.RAM.PermissionAssociation CreatePermissionAssociation()
    {
        var permissionAssociationResult = new Humidifier.RAM.PermissionAssociation
        {
            GivenName = InputResourceName,
        };

        return permissionAssociationResult;
    }

} // End Of Class

public static class PermissionAssociationFactoryExtensions
{
}
