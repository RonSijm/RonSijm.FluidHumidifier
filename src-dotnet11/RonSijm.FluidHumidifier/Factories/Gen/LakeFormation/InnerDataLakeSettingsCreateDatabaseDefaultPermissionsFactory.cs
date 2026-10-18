// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataLakeSettingsCreateDatabaseDefaultPermissionsFactory(Action<Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions>
{

    protected override Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions Create()
    {
        var createDatabaseDefaultPermissionsResult = CreateCreateDatabaseDefaultPermissions();
        factoryAction?.Invoke(createDatabaseDefaultPermissionsResult);

        return createDatabaseDefaultPermissionsResult;
    }

    private Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions CreateCreateDatabaseDefaultPermissions()
    {
        var createDatabaseDefaultPermissionsResult = new Humidifier.LakeFormation.DataLakeSettingsTypes.CreateDatabaseDefaultPermissions();

        return createDatabaseDefaultPermissionsResult;
    }

} // End Of Class

public static class InnerDataLakeSettingsCreateDatabaseDefaultPermissionsFactoryExtensions
{
}
