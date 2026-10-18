// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsDatabaseResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DatabaseResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.DatabaseResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.DatabaseResource Create()
    {
        var databaseResourceResult = CreateDatabaseResource();
        factoryAction?.Invoke(databaseResourceResult);

        return databaseResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.DatabaseResource CreateDatabaseResource()
    {
        var databaseResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.DatabaseResource();

        return databaseResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsDatabaseResourceFactoryExtensions
{
}
