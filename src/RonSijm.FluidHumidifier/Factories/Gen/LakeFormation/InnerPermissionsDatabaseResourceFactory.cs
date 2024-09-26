// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPermissionsDatabaseResourceFactory(Action<Humidifier.LakeFormation.PermissionsTypes.DatabaseResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PermissionsTypes.DatabaseResource>
{

    protected override Humidifier.LakeFormation.PermissionsTypes.DatabaseResource Create()
    {
        var databaseResourceResult = CreateDatabaseResource();
        factoryAction?.Invoke(databaseResourceResult);

        return databaseResourceResult;
    }

    private Humidifier.LakeFormation.PermissionsTypes.DatabaseResource CreateDatabaseResource()
    {
        var databaseResourceResult = new Humidifier.LakeFormation.PermissionsTypes.DatabaseResource();

        return databaseResourceResult;
    }

} // End Of Class

public static class InnerPermissionsDatabaseResourceFactoryExtensions
{
}
